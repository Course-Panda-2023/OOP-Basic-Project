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
            string announcment = $"{this.name}: Who should I choose? \n";
            announcment += $"{this.name}: The winner is {winner.GetName()}!";
            Console.WriteLine(announcment);

        }
        public Singer Duel(Singer singer1, Singer singer2)
        {
            Singer[] singers = { singer1, singer2 };
            Singer winner = this.ChooseWinner(singers);
            this.AnnounceWinner(winner);
            return winner;
        }
        
    }
}