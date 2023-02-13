using OOPFinal.MusicPeople;
using OOPFinal.MusicPeople.Participants;
using OOPFinal.Songs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOPFinal.Competitions
{
    class JudgeCompetition : Competition
    {
        private List<Competitor> competitors = new List<Competitor>();
        private Songs.Songs songs;
        private Judge judge;
        private Random rnd = new Random();

        public JudgeCompetition(List<Competitor> competitors, Songs.Songs songs, Judge judge)
        {
            this.competitors = competitors;
            this.songs = songs;
            this.judge = judge;
        }

        public void runCompetition()
        {
            Console.WriteLine("Welcome to our singing competition!!\n");

            int singerId1;
            Competitor singer1;
            Song song1;
            int singerId2;
            Competitor singer2;
            Song song2;

            int winnerId;
            Competitor winner = competitors.ElementAt(0);

            int round = 1;
            while (competitors.Count() > 1)
            {
                Console.WriteLine($"Round {round}:");

                singerId1 = rnd.Next(competitors.Count());
                singer1 = competitors[singerId1];
                song1 = songs.GetSong();

                do
                {
                    singerId2 = rnd.Next(competitors.Count());
                }
                while (singerId2 == singerId1);
                singer2 = competitors[singerId2];
                song2 = songs.GetSong();

                Console.WriteLine($"The first singer {singer1.Name} will sing \"{song1.Name}\".\n" +
                    $"\"{song1.FirstLine}\"\n\n" +
                    $"The second singer {singer2.Name} will sing \"{song2.Name}\".\n" +
                    $"\"{song2.FirstLine}\"\n");

                winnerId = rnd.Next(2);
                if (winnerId == 0)
                {
                    winner = singer1;
                    competitors.RemoveAt(singerId2);
                }
                else
                {
                    winner = singer2;
                    competitors.RemoveAt(singerId1);
                }
                Console.WriteLine($"The winner that {judge.Name} chose is.. {winner.Name}!\n" +
                $"Lets hear what simon has to say about the winner's performance:\n" +
                $"\"{judge.GetUniqueResponse()}\"\n");

                round++;
            }

            Console.WriteLine($"The competition is over:\n" +
                $"The finale winner is {winner.Name}!!");

            Console.ReadLine();
        }
    }
}
