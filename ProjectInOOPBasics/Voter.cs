using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectInOOPBasics
{
    internal class Voter : IVoters
    {
        public int MakeYourVote(params string[] competitors)
        {
            Random random = new Random();
            return random.Next(0, 2);
        }
    }
}
