using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopFinal
{
    internal class Band : MemberInCompetition,ParticipantInCompetition
    {
        private List<Singer> bandMember;

        public Band(string name , List<Singer> bandmember) : base(name)
        {
            this.bandMember=new List<Singer>(bandmember);
        }
        public override string Desccription()
        {
            return "we are the " + name ;
        }

        public string getName()
        {
            return name;
        }

        public void Sing(Song song)
        {
            Console.WriteLine("-------------------");
            Console.WriteLine($"{this.name} ( {song.Name} ) : ");
            foreach(Singer singer in bandMember) {Console.WriteLine($"{singer.getName()} ( {song.Name} ) : {song.Lyrics}"); }
            Console.WriteLine("-------------------");
            
        }
    }
}
