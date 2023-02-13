using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OopFinal
{
    internal class Drummer : MemberInCompetition, BandMember
    {
        public Drummer(string name) : base(name)
        {

        }

        public override string Desccription()
        {
            return "hello my name is " + name + "and i am a drummer";
        }

        public string getName()
        {
            return name;
        }

        public void play(Song song)
        {
            Console.WriteLine($"{this.name}-{role()} ( {song.Name} ) : drum noises"); ;
        }

        public string role()
        {
            return "drummer";
        }
    }
}
