using System;





namespace OOPBasicProject
{
    class Helper
    {
        public static void SelectingSongsBySingers(List<Singer> singers, List<Song> list)
        {
            foreach (OOPBasicProject.Singer singer in singers)
            {
                singer.SelectRandomSongFromList(list);
            }
        }
        public static Dictionary<OOPBasicProject.Singer, int> GetVotesFromJury(List<OOPBasicProject.Singer> singers, List<OOPBasicProject.Jury> juries)
        {
            Dictionary<OOPBasicProject.Singer, int> voteCounts = new Dictionary<OOPBasicProject.Singer, int>();
            foreach (OOPBasicProject.Jury jury in juries)
            {
                //Selects winner
                OOPBasicProject.Singer winner = jury.SelectWinnerRandomly(singers);
                if (voteCounts.ContainsKey(winner))
                {
                    voteCounts[winner]++;
                }
                else
                {
                    voteCounts[winner] = 1;
                }
            }
            return voteCounts;
        }
        public static OOPBasicProject.Singer GetAbsoluteWinner(Dictionary<OOPBasicProject.Singer, int> voteCounts)
        {
            Singer absoluteWinner = null;
            int maxVotes = 0;
            foreach (KeyValuePair<Singer, int> voteCount in voteCounts)
            {
                //Counts votes of every jury for every participant
                if (voteCount.Value > maxVotes)
                {
                    maxVotes = voteCount.Value;
                    absoluteWinner = voteCount.Key;
                }
            }
            return absoluteWinner;
        }
    }
}