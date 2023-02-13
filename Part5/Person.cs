using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part5
{
    public class Person
    {
        protected int PersonId { get; }
        public string Name { get; }
        protected double HighetInMeters { get; }

        public Person(int personId, string name, double highetInMeters)
        {
            PersonId = personId;
            Name = name;
            HighetInMeters = highetInMeters;
        }
    }
}
