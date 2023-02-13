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
                OOPBasicProject.Singer winner = jury.VoteForSinger(singers);
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
        public static List<List<OOPBasicProject.Singer>> MakeRandomPairs(List<OOPBasicProject.Singer> singers)
        {
            List<List<OOPBasicProject.Singer>> pairs = new List<List<OOPBasicProject.Singer>>();
            Random rnd = new Random();
            while (singers.Count > 0)
            {
                int index = rnd.Next(singers.Count);
                OOPBasicProject.Singer singer1 = singers[index];
                singers.RemoveAt(index);
                index = rnd.Next(singers.Count);
                OOPBasicProject.Singer singer2 = singers[index];
                singers.RemoveAt(index);                
                pairs.Add(new List<OOPBasicProject.Singer>() { singer1, singer2});
            }
            return pairs;
        }

        public static string RandomString(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, length)
                             .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        

        public static List<Audience> MakeRandomAudienceList() 
        {
            List<Audience> audience = new List<Audience>();
            Random rnd = new Random();
            int rand_number = rnd.Next(1, 100);           
            

            for (int i = 0; i < rand_number; i++)
            {
                int rand_length = rnd.Next(3, 11);
                string name = RandomString(rand_length);
                int age = rnd.Next(2, 10);
                string city = RandomString(rand_length);
                string country = RandomString(rand_length);
                audience.Add(new Audience(name, age, city, country));
            }
            return audience;
        }
        // TODO: To unite with the same function for jury
        public static Dictionary<OOPBasicProject.Singer, int> GetVotesFromAudience(List<OOPBasicProject.Singer> singers, List<OOPBasicProject.Audience> audience)
        {
            Dictionary<OOPBasicProject.Singer, int> voteCounts = new Dictionary<OOPBasicProject.Singer, int>();
            foreach (OOPBasicProject.Audience audience_member in audience)
            {
                //Selects winner
                OOPBasicProject.Singer winner = audience_member.VoteForSinger(singers);
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
    }
}