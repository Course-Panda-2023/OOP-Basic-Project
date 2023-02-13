using System.Text.Json;
namespace Music
{
    class Competition
    {
        private List<Competitor> _competitors;
        private Judge _judge;
        private string[] _listSongs;
        private int _amountOfCrowd;

        public Competition(Judge judge, string pathCompetitors, string pathFileSongs, int amountOfCrowd)
        {
            _judge = judge;
            _competitors = GetListCompetitors(pathCompetitors);
            _listSongs = File.ReadAllLines(pathFileSongs);
            _amountOfCrowd = amountOfCrowd;
        }

        private List<Competitor> GetListCompetitors(string pathCompetitors)
        {
            string[] lines = File.ReadAllLines(pathCompetitors);
            List<Competitor> competitors = new List<Competitor>();
            int i = 0;
            if (lines[i] == "Singers")
            {
                i++;
                while (lines[i] != "Bands")
                {
                    competitors.Add(new Singer(lines[i]));
                    i++;
                }
                i++; // Band Row
                while (i < lines.Length)
                {
                    competitors.Add(new Band(lines[i]));
                    i++;
                }
            }
            return competitors;
        }

        private Competitor ChoiceRandomCompetitor()
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(_competitors.Count);
            Competitor choice = _competitors[randomNumber];
            return choice;
        }

        public void Start()
        {
            Console.WriteLine(_competitors.Count);
            while(_competitors.Count > 1)
            {
                // All of the singers in the competition show
                foreach (Competitor competitor in _competitors)
                    competitor.Sing(_listSongs);
                Console.WriteLine("**************************");
                // Voting Time
                Dictionary<Competitor, int>  votes = Voting();
                // Print the votes
                foreach (KeyValuePair<Competitor,int> item in votes)
                    Console.WriteLine($"{item.Key} got {item.Value} votes.");
                // Update the singers in the competition
                UpdateSingers(votes);
                Console.WriteLine("**************************");
            }
            Console.WriteLine("**************************");
            Console.WriteLine($"The BIGGEST Winner is {_competitors[0]}");
        }

        private Dictionary<Competitor, int> Voting()
        {
            Dictionary<Competitor, int> votes = new Dictionary<Competitor, int>();
            // initiate the dictionary with 0s
            foreach (Competitor competitor in _competitors)
                votes[competitor] = 0;
            for (int i = 0; i < _amountOfCrowd; i++)
                // update the number of votes for random singer
                votes[ChoiceRandomCompetitor()]++;
            return votes;
        }

        private void UpdateSingers(Dictionary<Competitor, int> votes)
        {
            int maxVotes = votes.Values.Max();
            List<Competitor> updatedList = new List<Competitor>();
            foreach (Competitor competitor in _competitors)
            {
                if (votes[competitor] == maxVotes)
                    updatedList.Add(competitor);
            }
            _competitors = updatedList;
        }
    }
}
