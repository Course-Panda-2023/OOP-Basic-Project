using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopFinal
{
    internal class Song
    {
        private string name { set; get; }
        private string lyrics { set; get; }

        public string Name { get { return name; } set { name = value; } }
        public string Lyrics { get { return lyrics; } set { lyrics = value; } }

        public Song(string name, string lyrics)
        {
                this.name = name;   
                this.lyrics = lyrics;   
        }

    }
}
