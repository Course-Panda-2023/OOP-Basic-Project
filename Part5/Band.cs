using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part5
{
    public class Band : Contestant
    {
        private string BandName;
        private int MembersAmount;
        private List<Singer> Singers;
        private List<Guitarist> Guitarists;
        private List<Drummer> Drummers;

        public Band(string bandName, bool doesPlay, bool doesWrite,
            List<Singer> singers, List<Guitarist> guitarists, List<Drummer> drummers)
            : base(doesPlay, doesWrite)
        {
            this.BandName = bandName;
            this.Singers = singers;
            this.Guitarists = guitarists;
            this.Drummers = drummers;
            this.MembersAmount = singers.Count() + guitarists.Count() + drummers.Count();

        }

        public bool IsValidLists()
        {
            if (this.Singers.Count() < 1 || this.Guitarists.Count() < 1 || this.Drummers.Count() < 1)
            {
                return false;
            }
            return true;
        }

        public override string GetName()
        {
            return this.BandName;
        }

        public override void Sing(Song song)
        {
            Console.WriteLine($"We are {this.BandName} and we will sing {song.SongName}!");
            foreach( Singer singer in Singers)
            {
                Console.WriteLine($"{singer.Name}: {song.SongWords}");

            }
            Console.WriteLine();
        }
    }
}
