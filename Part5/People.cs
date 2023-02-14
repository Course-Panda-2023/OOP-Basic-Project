using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasicProject
{    
    abstract class People
    {        
        private string _name;
        private int _age;
        private string _city;
        private string _country;
        
        protected People(string name, int age, string city, string country)
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
        public int Age
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
        public virtual string ToString()
        {
            return string.Format("Name: {0}, Age: {1}, City: {2}, Country: {3}", _name, _age, _city, _country);
        }
    }
}
