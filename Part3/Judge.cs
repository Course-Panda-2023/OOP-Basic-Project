using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3
{
    public class Judge
    {
        private string name;
        private int amountOfPeopleInTheAudience;

        public Judge(string name, int amountOfPeopleInTheAudience)
        {
            this.name = name;
            this.amountOfPeopleInTheAudience = amountOfPeopleInTheAudience;
        }

        public Singer Judging(params Singer[] singers)
        {
            var rand = new Random();
            int sum = amountOfPeopleInTheAudience / 2;

            if (amountOfPeopleInTheAudience <= 0)
                amountOfPeopleInTheAudience = 1;

            while(sum == amountOfPeopleInTheAudience / 2)
            {
                sum = 0;
                for (int i = 0; i < amountOfPeopleInTheAudience; i++)
                    sum += rand.Next(0, 2);
            }

            Singer winner = sum > amountOfPeopleInTheAudience / 2 ? singers[0] : singers[1];
            Console.WriteLine("The winner of the singing contest is...");
            Console.WriteLine(winner.Name);
            Console.WriteLine();
            return winner;
        }
    }
}
