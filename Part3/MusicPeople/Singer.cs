using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OOPFinal.Songs;

namespace OOPFinal.MusicPeople
{
    class Singer : Person
    {
        private List<Song> songs = new List<Song>();
        public Singer(string name, params Song[] songs) : base(name) 
        {
            foreach (Song song in songs)
                this.songs.Add(song);
        } 

        public Song GetSong()
        {
            Random rnd = new Random();
            int songId = rnd.Next(songs.Count);
            return songs[songId];
        }
    }
}
