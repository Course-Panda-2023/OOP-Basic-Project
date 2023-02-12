using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPprojectS
{
    class Song
    {
        string songString;
        string name;

        public Song(string name, string songString)
        {
            this.name = name;
            this.songString = songString;
        }

        public string getName(){
            return this.name;
        }

        public string getSong(){
            return this.songString;
        }
    }
}