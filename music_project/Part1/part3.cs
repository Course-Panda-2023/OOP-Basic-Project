using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contest
{
    public class ContestClass3 : ContestClass2
    {
        public static List<string> songs = new List<string>();


        public override void Run()
        {
            Init();
            AudienceClass audience = new AudienceClass(this.contestants);
            audience.Vote();
        }
    }
}