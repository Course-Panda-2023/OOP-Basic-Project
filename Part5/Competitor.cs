using System;

namespace OOPBasicProject
{
    internal class Competitor : People
    {

        private string _compName;
        private int _compAge;
        private string _compCity;
        private string _compCountry;
        private Song _song;
        private bool _performed;
        private int _voteCount;       
        protected Competitor(string name, int age, string city, string country) : base(name, age, city, country)
        {
            this._compName = name;
            this._compAge = age;
            this._compCity = city;
            this._compCountry = country;
        }

        public string CompetitorName
        {
            get { return _compName; }
            set { _compName = value; }
        }
        public int CompetitorAge
        {
            get { return _compAge; }
            set { _compAge = value; }
        }
        public string CompetitorCity
        {
            get { return _compCity; }
            set { _compCity = value; }
        }
        public string CompetitorCountry
        {
            get { return _compCountry; }
            set { _compCountry = value; }
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
            return CompetitorName;
        }
        public bool Performed
        {
            get { return _performed; }
            set { _performed = value; }
        }
        public void SelectRandomSongFromList(List<Song> songList)
        {
            Random random = new Random();
            int randomSongIndex = random.Next(0, songList.Count);
            Song = songList[randomSongIndex];
        }
        public void PerformSong()
        {
            if(_song != null)
            {
                Console.WriteLine(_compName + " didn't get a song!");
                Performed = false;
            }else if (!Performed)
            {
                Performed = true;
                return;
            }
            Performed = false;
        }
        
    }
    
}