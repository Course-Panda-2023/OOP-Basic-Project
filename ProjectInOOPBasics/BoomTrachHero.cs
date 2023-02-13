using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectInOOPBasics
{
    internal class BoomTrachHero : Hero
    {
        private string name;

        public BoomTrachHero(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }
    }
}
