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
        private int _voteCount;       
        public Competitor(string name, int age, string city, string country) : base(name, age, city, country)
        {
            _compName = name;
            _compAge = age;
            _compCity = city;
            _compCountry = country;
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

    }
    
}