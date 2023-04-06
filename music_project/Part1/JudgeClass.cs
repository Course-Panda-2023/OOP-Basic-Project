using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace contest
{
    class Judge
    {
        string name;
        public Judge(string name)
        {
            this.name = name;
        }
        /// <summary>
        /// prints winner and returns loser
        /// </summary>
        /// <param name="contestant1"></param>
        /// <param name="contestant2"></param>
        /// <returns></returns>
        public Contestant RunContest(Contestant contestant1,Contestant contestant2)
        {
            Console.WriteLine(name + " pairs " + contestant1.name + " against " + contestant2.name);
            var random = new Random(); // generates random double between 0 and 1
            double mood = random.NextDouble();

            double song1 = contestant1.sing();
            double song2 = contestant2.sing();

            (double proformace1, double proformace2) =(Math.Abs(mood - song1), Math.Abs(mood - song2));

            if (proformace1 == proformace2) // extremely low probability
            {
                Console.WriteLine("tie! starting rematch");
                return RunContest(contestant1, contestant2);
            }


            else if (proformace1 < proformace2)
            {
                Console.WriteLine(contestant1.name + " won!");
                return contestant2;
            }

            else
            {
                Console.WriteLine(contestant2.name + " won!");
                return contestant1;
            }

        }
    }
}
