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
        public Participant Voting(Participant[] participants)
        {
            var votes = new Dictionary<Participant, int>();
            foreach (var participant in participants)
            {
                votes.Add(participant, 0);
            }
            for (int i = 0; i < this.size; i++)
            {
                Random rnd = new Random();
                int participantIndex = rnd.Next(participants.Length);
                votes[participants[participantIndex]]++;
            }
            Participant winner = votes.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
            return winner;
        }
    }
}