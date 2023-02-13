using System.Text.Json;
namespace Music
{
    class Competition
    {
        private List<Singer> _singers;
        private Judge _judge;

        public Competition(Judge judge, string pathSingers, string pathSongs)
        {
            _judge = judge;
            _singers = GetListSingers(pathSingers, pathSongs);
        }

        private List<Singer> GetListSingers(string pathFileSingers, string pathFileSongs)
        {
            string[] singers = File.ReadAllLines(pathFileSingers);
            string[] songs = File.ReadAllLines(pathFileSongs);
            List<Singer> listOfSingers = new List<Singer>();
            for (int i = 0; i < singers.Length; i++)
            {
                listOfSingers.Add(new Singer(singers[i], songs[i].Split()));
                listOfSingers[i].Sing();
            }
            return listOfSingers;
        }

        public List<Singer[]> LotteryCandidates()
        {
            List<Singer> copyListSingers = new List<Singer>();
            foreach (Singer singer in this._singers)
                copyListSingers.Add(singer);
            List<Singer[]> competeWith = new List<Singer[]>();
            // Assumption in this part even number of singers
            int numberOfLottery = this._singers.Count / 2;
            for (int i = 0; i < numberOfLottery; i++)
                competeWith.Add(ChoiceRandomTwoSingers(copyListSingers));
            return competeWith;
        }

        private Singer[] ChoiceRandomTwoSingers(List<Singer> copyListSingers)
        {
            Singer[] singersCompeteEachOther = new Singer[2];
            singersCompeteEachOther[0] = ChoiceRandomSinger(copyListSingers);
            singersCompeteEachOther[1] = ChoiceRandomSinger(copyListSingers);
            return singersCompeteEachOther;
        }

        private Singer ChoiceRandomSinger(List<Singer> copyListSingers)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(copyListSingers.Count);
            Singer choice = copyListSingers[randomNumber];
            copyListSingers.RemoveAt(randomNumber);
            return choice;
        }

        public void Start()
        {
            while(_singers.Count > 1)
            {
                List<Singer[]> candidates = LotteryCandidates();
                // create the duels
                foreach(Singer[] singers in candidates)
                {
                    Console.WriteLine("**************************");
                    Singer firstSinger = singers[0];
                    firstSinger.Sing();
                    Singer secondSinger = singers[1];
                    secondSinger.Sing();
                    // Choice winner
                    Singer winner = this._judge.ChoiceWinner(firstSinger, secondSinger);
                    // Remove the loser from the singers' list
                    if (winner == firstSinger)
                        this._singers.Remove(secondSinger);
                    else
                        this._singers.Remove(firstSinger);
                    Console.WriteLine($"The winner is {winner}");
                }
            }
            Console.WriteLine("**************************");
            Console.WriteLine($"The BIGGEST Winner is {_singers[0]}");
        }
    }
}
