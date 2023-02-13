using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part5
{
    public abstract class ContestManager
    {
        public static Contestant RunContestWithJudge(List<Contestant> contestentList, Judge judge, params Song[] songs)
        {
            if (contestentList.Count == 1)
            {
                return contestentList[0];
            } else
            {
                return RunContestWithJudge(GenerateNextRound(contestentList, judge, songs),judge, songs);
            }
        }

        public static int RandomContestentIndex(int numOfContestents)
        {
            Random rnd = new Random();
            return rnd.Next(numOfContestents);
        }

        public static Contestant RunContestWithAudience(List<Contestant> contestentList, int audienceAmount, params Song[] songs)
        {
            int currVotes = 0;
            foreach (Contestant contestent in contestentList)
            {
                contestent.Sing(SelectRandomSong(songs));
                contestent.Votes = currVotes;
            }

            for (int audienceIndex = 0; audienceIndex < audienceAmount; audienceIndex++)
            {
                int contestedIndex = RandomContestentIndex(contestentList.Count);
                contestentList[contestedIndex].Votes = contestentList[contestedIndex].Votes + 1;
            }
            return FindWinner(contestentList);
        }

        public static Contestant FindWinner(List<Contestant> contestentsList)
        {
            Contestant winner = contestentsList[0];
            foreach (Contestant contestent in contestentsList)
            {
                if (contestent.Votes > winner.Votes)
                {
                    winner = contestent;
                }
            }
            return winner;
        }
        public static List<Contestant> GenerateNextRound(List<Contestant> contestentList, Judge judge, params Song[] songs)
        {
            Contestant contestent1, contestent2, currentWinner;
            List<Contestant> winners = new List<Contestant>();

            if (contestentList.Count % 2 != 0 )
            {
                contestent1 = SelectRandomContestent(contestentList);
                contestentList.Remove(contestent1);
                winners.Add(contestent1);
            }
            int numOfContestents = contestentList.Count;
            for (int Counter = 0; Counter < numOfContestents / 2; Counter++)
            {
                contestent1 = SelectRandomContestent(contestentList);
                contestentList.Remove(contestent1);
                contestent2 = SelectRandomContestent(contestentList);
                contestentList.Remove(contestent2);

                contestent1.Sing(SelectRandomSong(songs));
                contestent2.Sing(SelectRandomSong(songs));
                currentWinner = judge.ChooseWinner(contestent1, contestent2);
                winners.Add(currentWinner);
            }
            return winners;
        }

        public static Contestant SelectRandomContestent(List<Contestant> contestents)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(contestents.Count-1);
            return contestents[randomIndex];
        }

        public static Song SelectRandomSong(params Song[] songs)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(songs.Length);
            return songs[randomIndex];
        }
    }
}
