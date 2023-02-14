using System;

namespace OOPBasicProject
{
    internal class Drummers : Competitor
    {
        
        private string _drummersName;
        private int _drummersAge;
        private string _drummersCity;
        private string _drummersCountry;
        private Song _song;
        private int _voteCount;

        public Drummers(string name) : base(name, 0, "Unknown", "Unknown")
        {
            this._drummersName = name;
            this._drummersAge = 0;
            this._drummersCity = "Unknown";
            this._drummersCountry = "Unknown";
        }

        public Drummers(string name, int age, string city, string country) : base(name, age, city, country)
        {
            this._drummersName = name;
            this._drummersAge = age;
            this._drummersCity = city;
            this._drummersCountry = country;
        }

        public string DrummersName
        {
            get { return _drummersName; }
            set { _drummersName = value; }
        }
        public int DrummersAge
        {
            get { return _drummersAge; }
            set { _drummersAge = value; }
        }
        public string DrummersCity
        {
            get { return _drummersCity; }
            set { _drummersCity = value; }
        }
        public string DrummersCountry
        {
            get { return _drummersCountry; }
            set { _drummersCountry = value; }
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
            return DrummersName;
        }
    }
}