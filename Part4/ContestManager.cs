using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part4
{
    public abstract class ContestManager
    {
        public static Contestent RunContestWithJudge(List<Contestent> contestentList, Judge judge, params Song[] songs)
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

        public static Contestent RunContestWithAudience(List<Contestent> contestentList, int audienceAmount, params Song[] songs)
        {
            int currVotes = 0;
            foreach (Contestent contestent in contestentList)
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

        public static Contestent FindWinner(List<Contestent> contestentsList)
        {
            Contestent winner = contestentsList[0];
            foreach (Contestent contestent in contestentsList)
            {
                if (contestent.Votes > winner.Votes)
                {
                    winner = contestent;
                }
            }
            return winner;
        }
        public static List<Contestent> GenerateNextRound(List<Contestent> contestentList, Judge judge, params Song[] songs)
        {
            Contestent contestent1, contestent2, currentWinner;
            List<Contestent> winners = new List<Contestent>();

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

        public static List<Contestent> ConvertToContestentList(params Contestent[] list)
        {
            List<Contestent> contestents= new List<Contestent>();
            foreach (Contestent contestent in list)
            {
                contestents.Add(contestent);
            }

            return contestents;
        }

        public static Contestent SelectRandomContestent(List<Contestent> contestents)
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
