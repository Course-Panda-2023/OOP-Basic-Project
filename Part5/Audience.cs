using System;


namespace OOPBasicProject
{

    internal class Audience : People
    {
        private string _audName;
        private int _audAge;
        private string _audCity;
        private string _audCountry;
        Competitor _singerChoice;
        


        public Audience(string name, int age, string city, string country) : base(name, age, city, country)
        {
            this._audName = name;
            this._audAge = age;
            this._audCity = city;
            this._audCountry = country;            
        }
        public Audience(string name) : base(name, 0, "Unknown", "Unknown")
        {
            this._audName = name;
            this._audAge = 0;
            this._audCity = "Unknown";
            this._audCountry = "Unknown";
        }


        public string AudienceName
        {
            get { return _audName; }
            set { _audName = value; }
        }
        public int AudienceAge
        {
            get { return _audAge; }
            set { _audAge = value; }
        }

        public string AudienceCuty
        {
            get { return _audCity; }
            set { _audCity = value; }
        }
        public string AudienceCountry
        {
            get { return _audCountry; }
            set { _audCountry = value; }
        }

        
        public Competitor VoteForSinger(List<Competitor> competitors)
        {
            Random rand = new Random();            
            int winnerIndex = rand.Next(competitors.Count);
            //TODO : optimize to avoid infinite loop
            while (!competitors[winnerIndex].Performed)
            {
                winnerIndex = rand.Next(competitors.Count);
            }
            _singerChoice = competitors[winnerIndex];
            return _singerChoice;
        }
        //public 
        public override string ToString()
        {
            return AudienceName;
        }
    }
}