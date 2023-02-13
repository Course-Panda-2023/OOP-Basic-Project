using OOPFinal.MusicPeople.Participants;
using OOPFinal.Songs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFinal.Competitions
{
    class AudienceCompetition : Competition
    {
        private List<Competitor> competitors = new List<Competitor>();
        private Songs.Songs songs;
        int numOfJudges;

        public AudienceCompetition(List<Competitor> competitors, Songs.Songs songs, int numOfJudges)
        {
            this.competitors = competitors;
            this.songs = songs;
            this.numOfJudges = numOfJudges;
        }

        public void runCompetition()
        {
            Console.WriteLine("Welcome to our singing competition!!\n");
            Song curSong;
            for (int i = 0; i < competitors.Count(); i++)
            {
                curSong = songs.GetSong();
                Console.WriteLine($"Our {i + 1} competitor is {competitors[i].Name} and will sing \"{curSong.Name}\".\n" +
                    $"\"{curSong.FirstLine}\"\n\n");
            }

            int[] votes = new int[competitors.Count];
            for (int i = 0; i < competitors.Count; i++)
                votes[i] = 0;
            int curVote;
            for (int i = 1; i <= numOfJudges; i++)
            {
                Console.WriteLine($"Judge {i} who would you like to vote for? (Enter the number of performance)");
                try
                {
                    votes[Convert.ToInt32(Console.ReadLine()) - 1]++;

                }
                catch (Exception) { Console.WriteLine("You've entered invalid value, vote will be ignored."); }
            }

            int maxVotes = votes.Max();
            List<string> winners = new List<string>();
            for (int i = 0; i < votes.Length; i++)
            {
                if (votes[i] == maxVotes)
                    winners.Add(competitors[i].Name);
            }

            if (winners.Count > 1)
                Console.WriteLine($"The competition is over:\n" +
                    $"The finale winners are {string.Join(", ", winners)}!!");
            else
                Console.WriteLine($"The competition is over:\n" +
                    $"The finale winner is {string.Join(", ", winners)}!!");
        }
    }
}
