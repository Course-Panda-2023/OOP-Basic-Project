using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part5
{
    public class Judge : Person
    {
        public Judge(int personId, string name, double highetInMeters, int yearsOfExperience, bool isTough) 
            : base(personId, name, highetInMeters)
        {
            this.JudgeId = JudgeCounter;
            JudgeCounter++;
            this.YearsOfExperience = yearsOfExperience;
            this.IsTough = isTough;
        }

        private static int JudgeCounter = 1;
        private int JudgeId;
        private int YearsOfExperience;
        private bool IsTough;

        public Contestent ChooseWinner(params Contestent[] contestents)
        {
            Random rnd = new Random();
            int winnerIndex = rnd.Next(contestents.Length);
            Console.WriteLine($"This is {base.Name} and I saw a shitshow but the winner is {contestents[winnerIndex].GetName()}");
            Console.WriteLine();
            return contestents[winnerIndex];
        }
    }
}
