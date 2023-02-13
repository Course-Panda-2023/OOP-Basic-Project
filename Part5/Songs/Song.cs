using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFinal.Songs
{
    class Song
    {
        private string name;
        public string Name { get { return name; } }

        private string firstLine;
        public string FirstLine { get { return firstLine; } }

        public Song(string name, string firstLine)
        {
            this.name = name;
            this.firstLine = firstLine;
        }
    }
}
