using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopFinal
{
    internal class Competition
    {
        private Judge competitionJudge;
        private List<Singer> singers=new List<Singer>();

        public Competition(List<Singer> l,Judge judge) { 
            this.competitionJudge = judge;
            singers = l;
         
        }

        public void compete()
        {
            int len = singers.Count;
            List<Singer> CopyList;
            Singer singer1,singer2,loser;
            Random rnd = new Random();  
            Console.WriteLine("Welcome to our song contest");
            
            while(singers.Count > 1) {
                PrintSingers();
                CopyList = new List<Singer>(singers);
                while (CopyList.Count > 1) {
                    singer1 = CopyList[rnd.Next(CopyList.Count)];
                    CopyList.Remove(singer1);
                    singer2 = CopyList[rnd.Next(CopyList.Count)];
                    loser=Competition1v1(singer1, singer2);
                    singers.Remove(loser);
                    CopyList.Remove(singer1);
                    CopyList.Remove(singer2);


                    Console.WriteLine("\n///////////////////////////\n");
                }
                Console.WriteLine("\n\nround is over!!!!!!!\n\n");
                //Console.ReadLine();
            
            }

            Console.WriteLine($"The winner is {singers[0].Name}");







        }
        public void PrintSingers()
        {
            Console.WriteLine($"\nour singers are:");
            foreach (Singer s in singers)
            {
                Console.Write($"{s.Name} ,");
            }
            Console.WriteLine("\n");    
            
        }
        public Singer Competition1v1(Singer singer1,Singer singer2)
        {
            Singer loser;
            Console.WriteLine($"Now we'll see {singer1.Name} vs {singer2.Name}");
            Console.WriteLine($"first performance is {singer1.Name}");
            singers[0].Sing("la la la");
            Console.WriteLine($"Now {singer2.Name} will sing");
            singers[1].Sing("la la la");
            Console.WriteLine($"lets hear what our judge {competitionJudge.Name} has to say");
            loser = competitionJudge.ToJudge(singer1, singer2);


            return loser;


        }
    }
}
