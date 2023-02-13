using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectInOOPBasics
{
    internal interface IVoters
    {
        int MakeYourVote(params string[] competitors);
    }
}
