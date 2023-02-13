using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    public class Contestent : Person
    {
        private static int ContestentCounter = 1;

        public Contestent(int personId, string name, double highetInMeters, bool doesPlay, bool doesWrite) : base(personId, name, highetInMeters)
        {
            ContestentId = ContestentCounter;
            ContestentCounter++;
            DoesPlay = doesPlay;
            DoesWrite = doesWrite;
        }

        private int ContestentId { get; set; }
        private bool DoesPlay { get; set; }
        private bool DoesWrite { get; set; }

        public void Sing(Song song)
        {
            Console.WriteLine($"My name is {base.Name} and i'm going to sing: {song.SongName}");
            Console.WriteLine(song.SongWords);
            Console.WriteLine();

        }
    }
}
