using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFinal
{
    class Song
    {
        private string name;
        public string Name { get { return name; } }

        public Song(string songName) 
        {
            this.name = songName;
        }
    }
}
