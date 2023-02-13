using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part5
{
    public class Band : Contestent
    {
        private string BandName;
        private int MembersAmount;
        private List<Singer> Singers;
        private List<Guitarist> Guitarists;
        private List<Drummer> Drummers;

        public Band(string bandName, int membersAmount, bool doesPlay, bool doesWrite, List<Singer> singers) : base(doesPlay, doesWrite)
        {
            BandName= bandName;
            MembersAmount = membersAmount;

            if (singers.Count() < 1)
            {
                throw new EmptyBandException("no singers added", bandName);
            }
            Singers = singers;

        }

        public Band(string bandName, int membersAmount, bool doesPlay, bool doesWrite,
            List<Singer> singers, List<Guitarist> guitarists, List<Drummer> drummers)
            : base(doesPlay, doesWrite)
        {
            BandName = bandName;
            MembersAmount = membersAmount;

            if (singers.Count() < 1 || guitarists.Count() < 1 || drummers.Count() < 1 )
            {
                throw new EmptyBandException("no singers/guitarists/drummers added", bandName);
            }
            this.Singers = singers;
            this.Guitarists = guitarists;
            this.Drummers = drummers;
        }

        public override string GetName()
        {
            return this.BandName;
        }

        public override void Sing(Song song)
        {
            Console.WriteLine($"We are {this.BandName} and we will sing {song.SongName}!");
            foreach( Singer singer in Singers )
            {
                Console.WriteLine($"{singer.Name}: {song.SongWords}");

            }
            Console.WriteLine();
        }
    }
}
