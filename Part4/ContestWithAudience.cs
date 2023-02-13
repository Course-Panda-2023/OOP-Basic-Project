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
        private Dictionary<Performer, int> scores;

        public ContestWithAudience(List<Performer> performers, List<Song> songsList)
        {
            this.performersList = performers;
            Random rnd = new Random();
            this.amountOfPeopleInAudience = rnd.Next(10, 100);
            this.scores = new Dictionary<Performer, int>();
            this.songsList = songsList;
        }



        public override void performContest()
        {
            Random rnd = new Random();
            Performer winner = new Singer("", new List<Song>());
            bool isThereWinner = false;
            List<Performer> participants = new List<Performer>(this.performersList);
            Console.WriteLine("Performing contest.\n" +
            "\nThe participants are:");
            foreach (Performer s in this.performersList)
            {
                Console.WriteLine(s.getName());
            }
            foreach (Performer s in this.performersList)
            {
                s.singFromList(this.songsList);
            }
            foreach (Performer s in this.performersList)
            {
                this.scores.Add(s, 0);
            }
            while (!isThereWinner)
            {
                for (int i = 0; i < this.amountOfPeopleInAudience; i++)
                {
                    int singerIndex = rnd.Next(0, this.performersList.Count);
                    this.scores[this.performersList.ElementAt(singerIndex)]++;
                }
                int maxVotes = this.scores.Values.Max();
                int amountOfMaxVotes = 0;
                foreach (Performer s in this.scores.Keys)
                {
                    if (this.scores[s] == maxVotes)
                    {
                        amountOfMaxVotes++;
                    }
                }
                if (amountOfMaxVotes == 1)
                {
                    foreach (Performer s in this.scores.Keys)
                    {
                        if (this.scores[s] == maxVotes)
                        {
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