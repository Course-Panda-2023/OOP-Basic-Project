using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPprojectS
{
    public class Singer : Musician
    {

        public Singer(string name, List<Song> songList) : base(name, songList)
        {

        }

        public override string getProffession()
        {
            return "Singer";
        }

        public override void Sing()
        {
            Console.WriteLine("Now " + this.name + " sings:");
            Console.WriteLine(this.getRandomSongInList().getSong());
        }

        public override void singFromList(List<Song> songsList)
        {
            Console.WriteLine("Now " + this.name + " sings:");
            Console.WriteLine(this.chooseSongFromList(songsList).getSong());
        }
    }
}