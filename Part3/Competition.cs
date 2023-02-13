using System.Text.Json;
namespace Music
{
    class Competition
    {
        private List<Singer> _singers;
        private Judge _judge;
        private string[] _listSongs;
        private int _amountOfCrowd;

        public Competition(Judge judge, string pathSingers, string pathFileSongs, int amountOfCrowd)
        {
            _judge = judge;
            _singers = GetListSingers(pathSingers);
            _listSongs = File.ReadAllLines(pathFileSongs);
            _amountOfCrowd = amountOfCrowd;
        }

        private List<Singer> GetListSingers(string pathFileSingers)
        {
            string[] singers = File.ReadAllLines(pathFileSingers);
            List<Singer> listOfSingers = new List<Singer>();
            for (int i = 0; i < singers.Length; i++)
            {
                listOfSingers.Add(new Singer(singers[i]));
            }
            return listOfSingers;
        }

        private Singer ChoiceRandomSinger()
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(_singers.Count);
            Singer choice = _singers[randomNumber];
            return choice;
        }

        public void Start()
        {
            while(_singers.Count > 1)
            {
                // All of the singers in the competition show
                foreach (Singer singer in _singers)
                    singer.Sing(_listSongs);
                Console.WriteLine("**************************");
                // Voting Time
                Dictionary<Singer, int>  votes = Voting();
                // Print the votes
                foreach (KeyValuePair<Singer,int> item in votes)
                    Console.WriteLine($"{item.Key} got {item.Value} votes.");
                // Update the singers in the competition
                UpdateSingers(votes);
                Console.WriteLine("**************************");
            }
            Console.WriteLine("**************************");
            Console.WriteLine($"The BIGGEST Winner is {_singers[0]}");
        }

        private Dictionary<Singer, int> Voting()
        {
            Dictionary<Singer, int> votes = new Dictionary<Singer, int>();
            // initiate the dictionary with 0s
            foreach (Singer singer in _singers)
                votes[singer] = 0;
            for (int i = 0; i < _amountOfCrowd; i++)
                // update the number of votes for random singer
                votes[ChoiceRandomSinger()]++;
            return votes;
        }

        private void UpdateSingers(Dictionary<Singer, int> votes)
        {
            int maxVotes = votes.Values.Max();
            List<Singer> updatedList = new List<Singer>();
            foreach (Singer singer in _singers)
            {
                if (votes[singer] == maxVotes)
                    updatedList.Add(singer);
            }
            _singers = updatedList;
        }
    }
}
