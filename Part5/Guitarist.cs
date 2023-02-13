using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part5
{
    public class Guitarist : Person
    {
        private string GuitarKind;

        public Guitarist(int personId, string name, double highetInMeters, string guitarKind) : base(personId, name, highetInMeters)
        {
            this.GuitarKind = guitarKind;
        }
    }
}
