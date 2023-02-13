using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part4
{
    public class Song
    {
        public string SongName { get; set; }
        public string SongWords { get; set; }

        public Song(string songName, string songWords)
        {
            this.SongName = songName;
            SongWords = songWords;
        }
    }
}
