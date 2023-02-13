using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPprojectS
{
    public class Guitarist : Musician
    {

        public Guitarist(string name, List<Song> songList) : base(name, songList)
        {

        }

        public override string getProffession()
        {
            return "Guitarist";
        }

        public override void Sing()
        {
            Console.WriteLine("Now " + this.name + " plays the guitar.");
        }

        public override void singFromList(List<Song> songsList)
        {
            Console.WriteLine("Now " + this.name + " plays the guitar.");
        }
    }
}