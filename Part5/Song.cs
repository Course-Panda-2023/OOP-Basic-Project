using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part5
{
    public class Song
    {
        public string SongName { get; }
        public string SongWords { get; }

        public Song(string songName, string songWords)
        {
            this.SongName = songName;
            this.SongWords = songWords;
        }
    }
}
