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
            
            int numberSingers = int.Parse(lines[0]);
            // Add all singers from the txt
            for (int i = 1; i <= numberSingers; i++)
                competitors.Add(new Singer(lines[i]));
            // Add all the bands with their members
            int numberBands = numberSingers + int.Parse(lines[numberSingers + 1]);
            for (int i = numberSingers + 2; i < lines.Length; i+=4)
            {
                List<string> stringBand = new List<string>();
                stringBand.Add(lines[i]);
                stringBand.Add(lines[i+1]);
                stringBand.Add(lines[i+2]);
                stringBand.Add(lines[i+3]);
                ExpendBand band = GetBand(stringBand);
                if (band != null)
                    competitors.Add(band);
            }
            return competitors;
        }

        private ExpendBand GetBand(List<string> stringBand)
        {
            // All the parameters have to be include: Name, Singers, Guitarists and Drummers
            if (!(AllValuesExist(stringBand)))
                return null;
            string nameBand = "";
            List<Singer> singers = new List<Singer>();
            List<Drummer> drummers = new List<Drummer>();
            List<Guitarist> guitarists = new List<Guitarist>();
            foreach (string item in stringBand)
            {
                string[] splitStr = item.Split(':');
                switch (splitStr[0])
                {
                    case "Name":
                        nameBand = splitStr[1];
                        break;
                    case "Singers":
                        string[] singersStr = splitStr[1].Split(",");
                        foreach (string singer in singersStr)
                            singers.Add(new Singer(singer));
                        break;
                    case "Drummers":
                        string[] drummersStr = splitStr[1].Split(",");
                        foreach (string drummer in drummersStr)
                            drummers.Add(new Drummer(drummer));
                        break;
                    case "Guitarists":
                        string[] guitaristsStr = splitStr[1].Split(",");
                        foreach (string guitarist in guitaristsStr)
                            guitarists.Add(new Guitarist(guitarist));
                        break;
                }
                // There are all the details which band have to

            }
            if (drummers.Count > 0 &&
                    singers.Count > 0 &&
                    guitarists.Count > 0 &&
                    nameBand != "")
                return new ExpendBand(nameBand, singers, drummers, guitarists);
            return null;
        }

        private bool AllValuesExist(List<string> values)
        {
            if (values.Count < 4)
                return false;
            if (!values[0].Split(':')[0].Equals("Name") ||
                !values[1].Split(':')[0].Equals("Singers") ||
                !values[2].Split(':')[0].Equals("Guitarists") ||
                !values[3].Split(':')[0].Equals("Drummers"))
                return false;
            return true;
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
                // All of the singers/bands in the competition show
                foreach (Competitor competitor in _competitors)
                    competitor.Action(_listSongs);
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
