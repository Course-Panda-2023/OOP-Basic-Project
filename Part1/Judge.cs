﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
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
        private int JudgeId { get; set; }
        private int YearsOfExperience { get; set; }
        private bool IsTough { get; set; }

        public Contestent ChooseWinner(params Contestent[] contestents)
        {
            Random rnd = new Random();
            int winnerIndex = rnd.Next(contestents.Length);
            Console.WriteLine($"This was a shitshow but the winner is {contestents[winnerIndex].Name}");
            return contestents[winnerIndex];
        }
    }
}
