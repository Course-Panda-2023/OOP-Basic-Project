﻿using System;





namespace OOPBasicProject
{
    class Helper
    {
        //TODO Delete it
       /* public static void SelectingSongsBySingers(List<Competitor> competitors, List<Song> list)
        {
            foreach (OOPBasicProject.Singer competitor in competitors)
            {
                competitor.SelectRandomSongFromList(list);
            }
        }*/
        public static void SelectingSongsByCompetitors(List<Competitor> competitors, List<Song> list)
        {
            foreach (OOPBasicProject.Singer competitor in competitors)
            {
                competitor.SelectRandomSongFromList(list);
            }
        }
        public static Dictionary<OOPBasicProject.Competitor, int> GetVotesFromJury(List<OOPBasicProject.Competitor> competitors, List<OOPBasicProject.Jury> juries)
        {
            Dictionary<OOPBasicProject.Competitor, int> voteCounts = new Dictionary<OOPBasicProject.Competitor, int>();
            foreach (OOPBasicProject.Jury jury in juries)
            {
                //Selects winner
                OOPBasicProject.Competitor winner = jury.VoteForSinger(competitors);
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
        public static OOPBasicProject.Competitor GetAbsoluteWinner(Dictionary<OOPBasicProject.Competitor, int> voteCounts)
        {
            Competitor absoluteWinner = null;
            int maxVotes = 0;
            foreach (KeyValuePair<Competitor, int> voteCount in voteCounts)
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
        public static List<List<OOPBasicProject.Competitor>> MakeRandomPairs(List<OOPBasicProject.Competitor> singers)
        {
            List<List<OOPBasicProject.Competitor>> pairs = new List<List<OOPBasicProject.Competitor>>();
            Random rnd = new Random();
            while (singers.Count > 0)
            {
                int index = rnd.Next(singers.Count);
                OOPBasicProject.Competitor singer1 = singers[index];
                singers.RemoveAt(index);
                index = rnd.Next(singers.Count);
                OOPBasicProject.Competitor singer2 = singers[index];
                singers.RemoveAt(index);                
                pairs.Add(new List<OOPBasicProject.Competitor>() { singer1, singer2});
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


        public static void AddRandomCompetitors(List<Competitor> competitors, in int number, string type)
        {
            int randLength;
            Random rnd = new Random();            
            for (int i = 0; i < number; i++)
            {
                randLength = rnd.Next(3, 12);
                if (type == "singer")
                {
                    competitors.Add(new Singer(Helper.RandomString(randLength)));
                } else if (type == "band")
                {
                    competitors.Add(new Band(Helper.RandomString(randLength)));
                }
                /*else if(type == "audience")
                {
                    competitors.Add(new Band(Helper.RandomString(randLength)));
                    //Console.WriteLine("Wrong type of competitor");
                }*/
                else
                {
                    Console.WriteLine("Wrong type of competitor");
                }          
            }
        }
        // TODO: To unite with the same function for jury and audience
        /* public static Dictionary<OOPBasicProject.Singer, int> GetVotesFromAudience(List<OOPBasicProject.Singer> singers, List<OOPBasicProject.Audience> audience)
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
         }*/
        public static Dictionary<OOPBasicProject.Competitor, int> GetVotesFromAudience(List<OOPBasicProject.Competitor> competitors, List<OOPBasicProject.Audience> audience)
        {
            Dictionary<OOPBasicProject.Competitor, int> voteCounts = new Dictionary<OOPBasicProject.Competitor, int>();
            foreach (OOPBasicProject.Audience audience_member in audience)
            {
                //Selects winner
                OOPBasicProject.Competitor winner = audience_member.VoteForSinger(competitors);
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