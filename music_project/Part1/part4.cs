using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contest
{
    internal class ContestClass4: ContestClass3
    {
        public override void Init()
        {
            base.Init();

            string[] BandNames = { "Backstreet boys", "Westlife" , "N’ Sync", "High Five", "Simple Plan", "Jonas Brother", "The Jackson 5" };
            foreach (string name in BandNames)
            {
                contestants.Add(new Band(name));
            }
        }
    }
}
