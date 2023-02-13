using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopFinal
{
    internal class Guitarists : MemberInCompetition, BandMember
    {
        public Guitarists(string name) : base(name)
        {
        }

        public override string Desccription()
        {
            return "hello my name is " + name + "and i am a guitarist";
        }

        public string getName()
        {
            return name;
        }

        public void play(Song song)
        {
            Console.WriteLine($"{this.name}-{role()} ( {song.Name} ) : guitar noises"); ;
        }

        public string role()
        {
            return "guitarists";
        }
    }
}
