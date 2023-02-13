using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part4
{
    public class Singer : Contestent
    {
        private int PersonId;
        public string Name;
        private double HighetInMeters;

        public Singer(int personId, string name, double highetInMeters, bool doesPlay, bool doesWrite) : base(doesPlay, doesWrite)
        {
            PersonId = personId;
            Name = name;
            HighetInMeters = highetInMeters;
        }

        public override void Sing(Song song)
        {
            Console.WriteLine($"I'm {this.Name} and I will sing {song.SongName}!");
            Console.WriteLine(song.SongWords);
            Console.WriteLine();
        }

        public override string GetName()
        {
            return this.Name;
        }
    }
}
