using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFinal
{
    class Singer : Person
    {
        List<Song> songs;

        public Singer (string name) : base(name)
        {
            this.songs = new List<Song> ();
        }
        public Singer (string name, List<Song> s) : base(name)
        {
            this.songs = s;
        }
        public string GetName() { return this.Name; }

    }
}
