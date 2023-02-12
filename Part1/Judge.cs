using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OopFinal
{
    internal class Judge:PersonInCompetition 
    {

        public Judge(String judgeName):base(judgeName) { }


        public Singer ToJudge(Singer singer1,Singer singer2)
        {
            Random rnd = new Random();
            if (rnd.Next(1, 3) == 1)
                Console.WriteLine($"{singer2.Name} was great,but {singer1.Name} was much better");
                return singer1;
            Console.WriteLine($"{singer1.Name} was great,but {singer2.Name} was much better");
            return singer2;

        }


        public override string Desccription()
        {
            return "Hello my name is "+this.name+"\nI am the judge of the competition ";
        }

    }
}
