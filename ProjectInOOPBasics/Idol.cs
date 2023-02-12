using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectInOOPBasics
{
    internal class Idol : IIdol
    {
        List<IIdol> idols = new List<IIdol>();
        public Idol(IIdol idol, IIdol anotherIdol) {
            this.idols.Add(idol);
            this.idols.Add(anotherIdol);
        }
        public void Execute()
        {
            var iterator = CollectionsMarshal.AsSpan(idols);
            foreach (var idol in iterator)
            {
                idol.Execute();
            }
        }
    }
}
