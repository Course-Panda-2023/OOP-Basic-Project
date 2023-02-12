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
            List<Song> songListCopy = new List<Song>(songList);
            songListCopy.Add(new Song("", ""));
            this.songList = songListCopy;
        }

        public string getName(){
            return this.name;
        }
        public Song getRandomSongInList(){
            Random r = new Random();
            int len = this.songList.Count();
            if (len == 1){
                return songList.ElementAt(0);
            }
            else{
                int indexOfsong = r.Next(0, len - 1);
                return songList.ElementAt(indexOfsong);
            }
        }

        public void Sing()
        {
            Console.WriteLine("Now " + this.name + " sings:");
            Console.WriteLine(this.getRandomSongInList().getSong());
        }
    }
}