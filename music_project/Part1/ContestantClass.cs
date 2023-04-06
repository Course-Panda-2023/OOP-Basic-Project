using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contest
{
    class Contestant
    {
        public string name;
        public Contestant(string name)
        {
            this.name = name;
        }
        /// <summary>
        /// simulates preformance of a song by generating random double between 0 and 1
        /// </summary>
        /// <returns></returns>
        public double sing()
        {
            var random = new Random();
            double song = random.NextDouble();
            return song;
        }
    }
}
