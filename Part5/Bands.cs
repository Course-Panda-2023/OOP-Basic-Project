using System;

namespace OOPBasicProject
{
    internal class Band : Competitor
    {

        private string _bandName;
        private int _bandAge;
        private string _bandCity;
        private string _bandCountry;
        private Song _song;
        private int _voteCount;
        private List<Competitor> _bandParticipants;
        private Random _random;
        //private Rando
        public Band(string name) : base(name, 0, "Unknown", "Unknown")
        {
            _bandName = name;
            _bandAge = 0;
            _bandCity = "Unknown";
            _bandCountry = "Unknown";
            _random = new Random();
            int randNum = _random.Next(2, 10);
            int randLength = _random.Next(3, 12);            
            _bandParticipants = new List<Competitor>();
            for (int i = 0; i < randNum; i++)
            {
                string randNames = Helper.RandomString(randLength);
                _bandParticipants.Add(new Singer(randNames));
            }
            //_bandParticipants = singers;
        }
        public Band(string name, int age, string city, string country, List<Competitor> singers) : base(name, age, city, country)
        {
            _bandName = name;
            _bandAge = age;
            _bandCity = city;
            _bandCountry = country;
            _bandParticipants = singers;
        }

        public string BandName
        {
            get { return _bandName; }
            set { _bandName = value; }
        }
        public int BandAge
        {
            get { return _bandAge; }
            set { _bandAge = value; }
        }
        public string BandCity
        {
            get { return _bandCity; }
            set { _bandCity = value; }
        }
        public string BandCountry
        {
            get { return _bandCountry; }
            set { _bandCountry = value; }
        }
        public Song Song
        {
            get { return _song; }
            set { _song = value; }
        }
        public int VoteCount
        {
            get { return _voteCount; }
            set { _voteCount = value; }
        }

        public override string ToString()
        {
            return BandName;
        }
        public void PrintBandParticipants()
        {
            foreach(Singer singer in _bandParticipants)
            {
                Console.WriteLine(singer.ToString());
            }
        }
        public void SelectSongByBandParticipants(List<Song> songsList)
        {
            Helper.SelectingSongsBySingers(_bandParticipants, songsList);
        }
    }
}