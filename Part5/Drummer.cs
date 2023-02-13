using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPprojectS
{
    public class Drummer : Musician
    {

        public Drummer(string name, List<Song> songList) : base(name, songList)
        {

        }

        public override string getProffession()
        {
            return "Drummer";
        }

        public override void Sing()
        {
            Console.WriteLine("Now " + this.name + " plays the drum.");
        }

        public override void singFromList(List<Song> songsList)
        {
            Console.WriteLine("Now " + this.name + " plays the drum.");
        }
    }
}