using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasicProject
{
    class Jury : People
    {
        private string _juryName;
        private int _juryAge;
        private string _juryCity;
        private string _juryCountry;
        //private People _singer;

        public Jury(string name, int age, string city, string country) : base(name, age, city, country)
        {
            _juryName = name;
            _juryAge = age;
            _juryCity = city;
            _juryCountry = country;
            //_singer = new Singer();
        }
        public string JuryName
        {
            get { return _juryName; }
            set { _juryName = value; }
        }
        public int JuryAge
        {
            get { return _juryAge; }
            set { _juryAge = value; }
        }
        public string JuryCity
        {
            get { return _juryCity; }
            set { _juryCity = value; }
        }
        public string JuryCountry
        {
            get { return _juryCountry; }
            set { _juryCountry = value; }
        }
        /* public new People SelectWinner(List<People> participants)
         {       

                 foreach (People participant in participants)
                 {
                     if 
                 }
                 return singer;            
         }*/
        public Singer SelectWinnerRandomly(List<Singer> singers)
        {
            Random rand = new Random();
            int winnerIndex = rand.Next(singers.Count);
            return singers[winnerIndex];
        }
        public override string ToString()
        {
            return _juryName;
        }
        //public 
    }
    
}
