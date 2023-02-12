namespace MySingingContest
{
    class Audience
    {
        public int size { get; set; }
        
        public Audience() 
        {
            Console.WriteLine("How many people are in the audience?");
            this.size = Int32.Parse(Console.ReadLine());
        }
        public Singer Voting(Singer[] singers)
        {
            var votes = new Dictionary<Singer, int>();
            foreach (var singer in singers)
            {
                votes.Add(singer, 0);
            }
            for (int i = 0; i < this.size; i++)
            {
                Random rnd = new Random();
                int singerIndex = rnd.Next(singers.Length);
                votes[singers[singerIndex]]++;
            }
            Singer winner = votes.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
            return winner;
        }
    }
}