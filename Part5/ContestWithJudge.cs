using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPprojectS
{
    public class ContestWithJudge : Contest
    {
        private Judge judge;
        private bool areBandsValid;

        public ContestWithJudge(List<Performer> performers, Judge judge)
        {
            this.performersList = performers;
            this.judge = judge;
            bool isThereSinger = false;
            bool isThereGuitarist = false;
            bool isThereDrummer = false;
            this.areBandsValid = true;
            foreach (Performer p in performers)
            {
                if (p is Band)
                {
                    foreach (Musician m in ((Band)p).getMusicians())
                    {
                        if (m is Singer)
                        {
                            isThereSinger = true;
                        }
                        if (m is Guitarist)
                        {
                            isThereGuitarist = true;
                        }
                        if (m is Drummer)
                        {
                            isThereDrummer = true;
                        }
                    }
                    if (!(isThereDrummer && isThereGuitarist && isThereSinger))
                    {
                        this.areBandsValid = false;
                    }
                }

            }
        }

        public override void performContest()
        {
            if (areBandsValid == false)
            {
                Console.WriteLine("Invalid bands! cannot perform contest");
                return;
            }
            Random rnd = new Random();
            List<Performer> participants = new List<Performer>(this.performersList);
            Console.WriteLine("Performing contest.\nThe judge is " + this.judge.getName() +
            "\nThe participants are:");
            foreach (Performer s in this.performersList)
            {
                Console.WriteLine(s.getName());
            }
            while (participants.Count != 1)
            {
                int randIndex1 = rnd.Next(participants.Count);
                int randIndex2 = randIndex1;
                while (randIndex2 == randIndex1)
                {
                    randIndex2 = rnd.Next(participants.Count);
                }
                Performer winner = this.judge.judge(participants.ElementAt(randIndex1), participants.ElementAt(randIndex2));
                Performer loser;
                if (winner == participants.ElementAt(randIndex1))
                {
                    loser = participants.ElementAt(randIndex2);
                }
                else
                {
                    loser = participants.ElementAt(randIndex1);
                }
                participants.Remove(loser);
            }
            Console.WriteLine("The ultimate winner is: " + participants.ElementAt(0).getName());
        }
    }
}