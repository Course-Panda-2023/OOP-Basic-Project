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
        protected double HeightInMeters { get; }

        public Person(int personId, string name, double highetInMeters)
        {
            this.PersonId = personId;
            this.Name = name;
            this.HeightInMeters = highetInMeters;
        }
    }
}
