using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopFinal
{
    internal class Helper
    {
        public static Dictionary<Singer, int> GetKeyFromValue(int valueVar,Dictionary<Singer,int> d)
        {
            Dictionary<Singer, int> ret= new Dictionary<Singer, int>();
            foreach (Singer singer in d.Keys.ToList())
            {
                Console.WriteLine($"{singer.Name} = {d[singer]} ");
                if (d[singer] == valueVar)
                {
                    ret.Add(singer, 0);
                }
            }
            return ret;
        }
    }
}
