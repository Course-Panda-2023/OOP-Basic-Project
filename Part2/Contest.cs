using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPprojectS
{
    class Contest
    {
        List<Singer> singersList;
        Judge judge;

        public Contest(List<Singer> singersList, Judge judge){
            this.singersList = singersList;
            this.judge = judge;
        }

        public void performContest(){
            Random rnd = new Random();
            List<Singer> participants = new List<Singer>(this.singersList);
            Console.WriteLine("Performing contest.\nThe judge is " + this.judge.getName() + 
            "\nThe participants are:");
            foreach(Singer s in this.singersList){
                Console.WriteLine(s.getName());
            }
            while(participants.Count != 1){
                int randIndex1 = rnd.Next(participants.Count);
                int randIndex2 = randIndex1;
                while (randIndex2 == randIndex1){
                    randIndex2 = rnd.Next(participants.Count);
                }
                Singer winner = this.judge.judge(participants.ElementAt(randIndex1), participants.ElementAt(randIndex2));
                Singer loser;
                if (winner == participants.ElementAt(randIndex1)){
                    loser = participants.ElementAt(randIndex2);
                }
                else{
                    loser = participants.ElementAt(randIndex1);
                }
                participants.Remove(loser);
            }
            Console.WriteLine("The ultimate winner is: " + participants.ElementAt(0).getName());
            
        }
    }
}