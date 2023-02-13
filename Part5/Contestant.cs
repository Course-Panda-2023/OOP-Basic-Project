using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part5
{
    public abstract class Contestant
    {
        private static int ContestentCounter = 1;

        public Contestant(bool doesPlay, bool doesWrite)
        {
            this.ContestentId = ContestentCounter;
            ContestentCounter++;
            this.DoesPlay = doesPlay;
            this.DoesWrite = doesWrite;
            this.Votes = 0;
        }

        protected int ContestentId;
        protected bool DoesPlay;
        protected bool DoesWrite;
        public int Votes { get; set; }

        public abstract void Sing(Song song);
        public abstract string GetName();
    }
}
