using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFinal.MusicPeople.Participants
{
    class Guitarist : Person, BandMember
    {
        private string role = ConstantsParticipants.GUITARIST_ROLE_NAME;
        public string Role { get { return role; } }
        public Guitarist(string name) : base(name) { }
    }
}
