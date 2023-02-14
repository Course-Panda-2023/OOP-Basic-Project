using System;

namespace OOPBasicProject
{
    internal class Guitarists : Competitor  
    {
        private string _name;
        private int _age;
        private string _city;
        private string _country;
        
        //private int _voteCount;

        public Guitarists(string name) : base(name, 0, "Unknown", "Unknown")
        {
            _name = name;
            _age = 0;
            _city = "Unknown";
            _country = "Unknown";
        }

        
        public Guitarists(string name, int age, string city, string country) : base(name, age, city, country)
        {
            _name = name;
            _age = age;
            _city = city;
            _country = country;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        /*public int DrummersAge
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
        }*/
        
        /*public int VoteCount
        {
            get { return _voteCount; }
            set { _voteCount = value; }
        }*/

        public override string ToString()
        {
            return Name;
        }
    }
}
       

