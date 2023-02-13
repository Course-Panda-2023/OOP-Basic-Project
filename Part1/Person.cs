using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    public class Person
    {
        protected int PersonId { get; set; }
        public string Name { get; set; }
        protected double HighetInMeters { get; set; }

        public Person(int personId, string name, double highetInMeters)
        {
            PersonId = personId;
            Name = name;
            HighetInMeters = highetInMeters;
        }
    }
}
