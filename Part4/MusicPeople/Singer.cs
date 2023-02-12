using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OOPFinal.Songs;

namespace OOPFinal.MusicPeople
{
    class Singer : Person, Competitor
    {
        public Singer(string name) : base(name) { } 
    }
}
