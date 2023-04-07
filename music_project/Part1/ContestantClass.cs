using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contest
{
    public class Contestant
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
        public virtual double sing()
        {
            var random = new Random();
            double song = random.NextDouble();
            return song;
        }
    }
    class ContestantPart3: Contestant
    {
        public ContestantPart3(string name):base(name) { }
        public override double sing()
        {
            Random rand =  new Random();
            int mySong = rand.Next( ContestClass3.songs.Count);
            Console.WriteLine(name + " chose to sing " + ContestClass3.songs[mySong]);
            return base.sing();
        }
    }
}
