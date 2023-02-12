using OOPFinal.Songs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFinal.MusicPeople
{
    class Band : Competitor
    {
        private string bandName;
        public string Name { get { return bandName; } }
        private List<Singer> bandMembers = new List<Singer>();

        public Band(string bandName, params Singer[] members)
        {
            this.bandName = bandName;
            foreach (Singer singer in members)
            {
                this.bandMembers.Add(singer);
            }
        }
    }
}
