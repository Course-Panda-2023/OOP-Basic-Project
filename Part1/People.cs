using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Advanced_local
{
    
    abstract class People
    {        
        private string _name;
        private string _age;
        private string _city;
        private string _country;
        public People(string name, string age, string city, string country)
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
        public string Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }
    }
}
