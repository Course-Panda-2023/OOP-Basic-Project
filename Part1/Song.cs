using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPprojectS
{
    public class Song
    {
        private string songString;
        private string name;

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