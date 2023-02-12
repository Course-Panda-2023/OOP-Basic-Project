using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectInOOPBasics
{
    internal class Singer : IIdol
    {
        private string name;

        public Singer(string name)
        {
            this.name = name;
        }
        public void Execute()
        {
            Console.Write($"{name} ");
        }
    }
}
