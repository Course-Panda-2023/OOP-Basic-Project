using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part5
{
    public class Band : Contestant
    {
        private List<Contestant> bandMembers;

        public Band(string name, params Contestant[] contestants) : base(name) 
        {
            bandMembers = new List<Contestant>();
            foreach(Contestant contestant in contestants)
            {
                bandMembers.Add(contestant);
            }
        }

        public bool ValidateBand()
        {
            int guitarCounter = 0;
            int drumCounter = 0;
            bool singer = false;
            foreach (Contestant contestant in bandMembers)
            {
                if (contestant is Guitarist)
                    guitarCounter++;
                else if(contestant is Drummer) 
                    drumCounter++;
                else if (contestant is Singer)
                    singer = true;
            }
            return singer && guitarCounter == 1 && drumCounter == 1;
        }
    }
}
