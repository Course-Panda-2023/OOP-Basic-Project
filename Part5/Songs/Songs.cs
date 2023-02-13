using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFinal.Songs
{
    class Songs
    {
        private List<Song> songs = new List<Song>();
        private Random rnd = new Random();

        public Songs(params Song[] songs)
        {
            foreach (Song song in songs)
                this.songs.Add(song);
        }

        public Song GetSong()
        {
            int songId = rnd.Next(songs.Count);
            return songs[songId];
        }
    }
}
