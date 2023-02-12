using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopFinal
{
    internal abstract class PersonInCompetition
    {
        protected string name;

        public PersonInCompetition(string name) {this.name = name;}
        public String Name { get { return name; } set { name = value; } }
        public abstract  String Desccription(); 

    }
}
