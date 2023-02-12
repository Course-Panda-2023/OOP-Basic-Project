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

        public Competition(Singer singer1,Singer singer2,Judge judge) { 
        this.competitionJudge = judge;
        singers.Add(singer1);
        singers.Add(singer2);   
         
        }

        public void compete()
        {
            Competition1v1(singers[0], singers[1]);
        }

        public void Competition1v1(Singer singer1,Singer singer2)
        {
            Singer winner;
            Console.WriteLine("Welcome to our song contest");
            Console.WriteLine($"first performance is {singer1.Name}");
            singers[0].Sing("la la la");
            Console.WriteLine($"Now {singer2.Name} will sing");
            singers[1].Sing("la la la");
            Console.WriteLine($"lets hear what our judge {competitionJudge.Name} has to say");
            winner=competitionJudge.ToJudge(singer1, singer2);
            Console.WriteLine($"{winner.Name} is our winner");


        }
    }
}
