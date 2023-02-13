using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectInOOPBasics
{
    internal class AudienceVote
    {
        private int numberOfPeople;
        private List<IVoters> voters = new List<IVoters>();

        public int NumberOfPeople
        {
            get { return numberOfPeople; }
            set { numberOfPeople = value; }
        }

        public int Match(params string[] competitors)
        {
            int[] competitorsVotes = new int[numberOfPeople];
            
            int indexOfTheVotedOne;
            foreach (var voter in voters)
            {
                indexOfTheVotedOne = voter.MakeYourVote();
                ++competitorsVotes[indexOfTheVotedOne];
            }
            //Array.IndexOf(competitors, competitorsVotes.Max())
            return new Random().Next(0, 2);
        }
    }
}
