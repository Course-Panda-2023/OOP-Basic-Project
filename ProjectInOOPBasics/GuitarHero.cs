using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectInOOPBasics
{
    internal class GuitarHero : Hero
    {
        private string name;

        public string Name
        {
            get { return name; }
        }

        public GuitarHero(string name)
        {
            this.name = name;
        }
    }
}
