using Part4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part4
{
    public abstract class Contestent
    {
        private static int ContestentCounter = 1;

        public Contestent(bool doesPlay, bool doesWrite)
        {
            ContestentId = ContestentCounter;
            ContestentCounter++;
            DoesPlay = doesPlay;
            DoesWrite = doesWrite;
            Votes = 0;
        }

        protected int ContestentId;
        protected bool DoesPlay;
        protected bool DoesWrite;
        public int Votes { get; set; }

        public abstract void Sing(Song song);
        public abstract string GetName();
    }
}
