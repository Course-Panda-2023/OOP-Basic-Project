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
        //private People _singer;


        public Audience(string name, int age, string city, string country) : base(name, age, city, country)
        {
            _audName = name;
            _audAge = age;
            _audCity = city;
            _audCountry = country;
            
        }


        public string AudienceName
        {
            get { return _audName; }
            set { _audName = value; }
        }
        /*public int AudienceAge
        {
            get { return _juryAge; }
            set { _juryAge = value; }
        }*//*
        
        public string AudienceCuty
        {
            get { return _juryCity; }
            set { _juryCity = value; }
        }
        public string AudienceCountry
        {
            get { return _juryCountry; }
            set { _juryCountry = value; }
        }*/

        /*public Singer VoteForSinger(List<Singer> singers)
        {
            Random rand = new Random();
            int winnerIndex = rand.Next(singers.Count);
            _singerChoice = singers[winnerIndex];
            return _singerChoice;
        }*/
        public Competitor VoteForSinger(List<Competitor> competitors)
        {
            Random rand = new Random();
            int winnerIndex = rand.Next(competitors.Count);
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