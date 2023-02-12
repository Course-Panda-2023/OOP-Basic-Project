using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopFinal
{
    internal class Helper
    {
        public static Dictionary<ParticipantInCompetition, int> GetKeyFromValue(int valueVar,Dictionary<ParticipantInCompetition, int> d)
        {
            Dictionary<ParticipantInCompetition, int> ret= new Dictionary<ParticipantInCompetition, int>();
            foreach (ParticipantInCompetition member in d.Keys.ToList())
            {
                Console.WriteLine($"{member.getName()} = {d[member]} ");
                if (d[member] == valueVar)
                {
                    ret.Add(member, 0);
                }
            }
            return ret;
        }
    }
}
