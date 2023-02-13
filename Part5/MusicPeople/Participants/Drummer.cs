using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFinal.MusicPeople.Participants
{
    class Drummer : Person, BandMember
    {
        private string role = ConstantsParticipants.DRUNNER_ROLE_NAME;
        public string Role { get { return role; } }
        public Drummer(string name) : base(name) { }
    }
}
