using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part5
{
    public class Drummer : Person
    {
        private string DrumsKind;
        private string SticksMaterial;

        public Drummer(int personId, string name, double highetInMeters, string drumsKind, string sticksMaterial) : base(personId, name, highetInMeters)
        {
            this.DrumsKind = drumsKind;
            this.SticksMaterial = sticksMaterial;
        }
    }
}
