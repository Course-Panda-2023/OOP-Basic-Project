using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Part3
{
    public class Contest
    {
        private List<Singer> contestants;
        private Judge judge;
        private List<Singer> winners;
        private int roundNum;
        private List<Song> songs;

        public Contest(Judge judge, List<Song> songList, params Singer[] singers) 
        {
            this.judge = judge;
            contestants = new List<Singer>();
            foreach (Singer singer in singers)
            {
                contestants.Add(singer);
            }
            roundNum = 1;
            winners = new List<Singer>();
            songs = new List<Song>();
            foreach(Song s in songList)
            {
                songs.Add(s);
            }
        }

        public void Dual(Singer singer1, Singer singer2)
        {
            var rand = new Random();
            singer1.Sing(songs[rand.Next(0, songs.Count)]);
            Console.WriteLine();
            singer2.Sing(songs[rand.Next(0, songs.Count)]);
            Console.WriteLine();

            Singer winner = judge.Judging(singer1, singer2);
            winners.Add(winner);
            contestants.Remove(singer1);
            contestants.Remove(singer2);
        }

        public List<Singer> Rounds()
        {
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine($"Starting round {roundNum}.");
            roundNum++;
            while (contestants.Count > 1)
            {
                var rand = new Random();
                int index2 = -1;
                int index1 = rand.Next(0, contestants.Count);
                int temp = rand.Next(0, contestants.Count);
                
                if (temp != index1)
                    index2 = temp;

                if(index2 != -1)
                    Dual(contestants[index1], contestants[index2]);
            }
            foreach (Singer singer in winners)
                contestants.Add(singer);
            
            winners.Clear();
            return contestants;
        }

        public Singer AllRounds()
        {
            Console.WriteLine("Starting Competition");
            List<Singer> singers = Rounds();
            while(singers.Count > 1)
            {
                singers = Rounds();
            }
            return singers[0];
        }
    }
}
