using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopFinal
{
    internal class Singer:MemberInCompetition ,ParticipantInCompetition
    {

        public Singer(String singerName):base(singerName) {
        } 

        public void Sing(Song song) {
            Console.WriteLine($"{this.name} ( {song.Name} ) : {song.Lyrics}");
        }

        public override string Desccription()
        {
            return "Hello my name is " + this.name + "\nI am a singer in the competition ";    
        }

        public string getName()
        {
            return name;
        }
    }
}
