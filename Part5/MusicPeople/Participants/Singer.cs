using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OOPFinal.Songs;

namespace OOPFinal.MusicPeople.Participants
{
    class Singer : Person, Competitor, BandMember
    {
        private string role = ConstantsParticipants.SINGER_ROLE_NAME;
        public string Role { get { return role; } }
        public Singer(string name) : base(name) { }
    }
}
