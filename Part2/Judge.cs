using System.Reflection;

namespace MySingingContest
{
    class Judge
    {
        private string name;

        public Judge(string name) 
        {
            this.name = name;
        }

        public string GetName() { return this.name; }

        public Singer ChooseWinner(Singer[] singers)
        {
            Song[] songList = new Song[0];
            for (int i = 0; i < singers.Length; i++)
            {
                songList.Append(singers[i].SingASong());
            }
            Random rnd = new Random();
            int num = rnd.Next(songList.Length);
            return singers[num];
        }
        public void AnnounceWinner(Singer winner) 
        {
            Console.WriteLine($"{this.name}: The winner is {winner.GetName()}!");

        }
        public Singer Duel(Singer singer1, Singer singer2)
        {
            Singer[] singers = { singer1, singer2 };
            Singer winner = this.ChooseWinner(singers);
            this.AnnounceWinner(winner);
            return winner;
        }

        // Part2:
        public void Tournament(Singer[] singers)
        {
            singers = RandomizeArray(singers);
            double rounds = Math.Ceiling(Math.Log2(singers.Length));
            for (int i = 0; i < rounds; i++)
            {
                int singersLeft = (int)Math.Pow(2, rounds - i);
                Console.WriteLine($"\nthis round will be held as if there are {singersLeft} singers left");
                for (int j = 0; j < singersLeft/2; j++)
                {
                    DuelInTournament(singers, j, j+singersLeft/2);
                }
            }
            string announcment = $"{this.name}: The Final winner is {singers[0].GetName()}!";
            Console.WriteLine(announcment);
        }

        public Singer[] RandomizeArray(Singer[] array)
        {
            Random rnd = new Random();
            Singer[] RandomArray = array.OrderBy(x => rnd.Next()).ToArray();
            return RandomArray;

        }

        public void DuelInTournament(Singer[] singers, int singer1Index, int singer2Index)
        {
            if (singer2Index < singers.Length)
            {
                singers[singer1Index] = Duel(singers[singer1Index], singers[singer2Index]);
                singers[singer2Index] = null;
                return;
            }
            Console.WriteLine($"{this.name}: {singers[singer1Index].GetName()} with {singers[singer1Index].GetSongs()[0].GetName()} wins automatically");
        }
    }
}