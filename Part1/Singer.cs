using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPprojectS
{
    class Singer
    {
        string name;
        List<Song> songList = new List<Song>();

        public Singer(string name, List<Song> songList)
        {
            this.name = name;
            songList.Add(new Song("", ""));
            this.songList = songList;
        }

        public string getName(){
            return this.name;
        }
        public Song getFirstSongInList(){
            return songList.ElementAt(0);
        }

        public void Sing()
        {
            Console.WriteLine("Now " + this.name + " sings:");
            Console.WriteLine(this.getFirstSongInList().getSong());
        }
    }
}