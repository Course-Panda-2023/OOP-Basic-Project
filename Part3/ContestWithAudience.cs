using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPprojectS
{
    class ContestWithAudience : Contest
    {
        private int amountOfPeopleInAudience;
        private List<Song> songsList;
        private Dictionary<Singer, int> scores;

        public ContestWithAudience(List<Singer> singersList, List<Song> songsList){
            this.singersList = singersList;
            Random rnd = new Random();
            this.amountOfPeopleInAudience = rnd.Next(10, 100);
            this.scores = new Dictionary<Singer, int>();
            this.songsList = songsList;
        }

        

        public override void performContest(){
            Random rnd = new Random();
            Singer winner = new Singer("", new List<Song>());
            bool isThereWinner = false;
            List<Singer> participants = new List<Singer>(this.singersList);
            Console.WriteLine("Performing contest.\n" + 
            "\nThe participants are:");
            foreach(Singer s in this.singersList){
                Console.WriteLine(s.getName());
            }
            foreach(Singer s in this.singersList){
                s.singFromList(this.songsList);
            }
            foreach (Singer s in this.singersList){
                this.scores.Add(s, 0);
            }
            while (!isThereWinner){
                for (int i = 0; i < this.amountOfPeopleInAudience; i++){
                int singerIndex = rnd.Next(0, this.singersList.Count);
                this.scores[this.singersList.ElementAt(singerIndex)]++;
                }
                int maxVotes = this.scores.Values.Max();
                int amountOfMaxVotes = 0;
                foreach (Singer s in this.scores.Keys){
                    if (this.scores[s] == maxVotes){
                        amountOfMaxVotes++;
                    }
                }
                if (amountOfMaxVotes == 1){
                    foreach (Singer s in this.scores.Keys){
                        if (this.scores[s] == maxVotes){
                            winner = s;
                            isThereWinner = true;
                        }
                    }
                }
            }
            
            Console.WriteLine("The ultimate winner is: " + winner.getName() + $" with {this.scores[winner]} votes.");
            
        }
    }
}