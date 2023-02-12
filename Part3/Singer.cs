using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3
{
    public class Singer
    {
        private string name;
        private Song song;

        public string Name { get { return name; } }

        public Singer (string name, List<Song> songs)
        {
            this.name = name;
            var rand = new Random();
            song = songs[rand.Next(0, songs.Count)];
        }

        public void Sing()
        {
            Console.WriteLine($"{name} started singing {song.songName}");
            Console.WriteLine(song.songLyrics);
        }
    }
}
