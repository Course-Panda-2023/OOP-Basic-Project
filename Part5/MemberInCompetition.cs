using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopFinal
{
    internal abstract class MemberInCompetition
    {
        protected string name;

        public MemberInCompetition(string name) {this.name = name;}
        public String Name { get { return name; } set { name = value; } }
        public abstract  String Desccription();


    }
}
