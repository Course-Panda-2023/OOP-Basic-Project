using OOPFinal.Songs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFinal.MusicPeople.Participants
{
    class Band : Competitor
    {
        private string bandName;
        public string Name { get { return bandName; } }
        private List<BandMember> bandMembers = new List<BandMember>();

        public Band(string bandName, params BandMember[] members)
        {
            this.bandName = bandName;
            bool isSinger = false;
            bool isDrummer = false;
            bool isGuitarist = false;
            foreach (BandMember member in members)
            {
                switch (member.Role)
                {
                    case ConstantsParticipants.SINGER_ROLE_NAME:
                        isSinger = true;
                        break;
                    case ConstantsParticipants.DRUNNER_ROLE_NAME:
                        isDrummer = true;
                        break;
                    case ConstantsParticipants.GUITARIST_ROLE_NAME:
                        isGuitarist = true;
                        break;
                    default:
                        break;
                }
                bandMembers.Add(member);
            }
            if (!isSinger || !isDrummer || !isGuitarist)
                throw new ArgumentException("Band is not valid! Must have a singer and a druummer and a guitarist!");
        }
    }
}
