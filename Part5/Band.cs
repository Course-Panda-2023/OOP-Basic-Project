using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopFinal
{
    internal class Band : MemberInCompetition,ParticipantInCompetition
    {
        private List<BandMember> bandMember=new List<BandMember>();

        public Band(string name , List<Singer> singersInBand,List<Guitarists> guitaristsInBand,List<Drummer> drummersInBand) : base(name)
        {
            if(singersInBand.Count==0)
                this.bandMember.Add(new Singer(this.name+"_singer"));
            else
                this.bandMember.AddRange(singersInBand);
            if (guitaristsInBand.Count == 0)
                this.bandMember.Add(new Guitarists(this.name + "_gitarist"));
            else
                this.bandMember.AddRange(guitaristsInBand);
            if (drummersInBand.Count == 0)
                this.bandMember.Add(new Drummer(this.name + "_drummer"));
            else
                this.bandMember.AddRange(drummersInBand);

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
            foreach(BandMember bandMember in bandMember) { bandMember.play(song); }
            Console.WriteLine("-------------------");
            
        }
    }
}
