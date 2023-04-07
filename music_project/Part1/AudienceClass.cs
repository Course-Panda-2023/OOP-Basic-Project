using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contest
{
    public class AudienceClass
    {
        int AudienceSize;
        List<(int score, Contestant Contestant)> scores = new List<(int, Contestant)>();

        public AudienceClass(List<Contestant>  contestants)
        {
            var random = new Random();
            AudienceSize = random.Next(10 * contestants.Count, 100 * contestants.Count);
            foreach(Contestant singer in contestants) 
            {
                scores.Add((0, singer));
            }
        }
        public void Vote()
        {
            Random random = new Random();
            for (int i = 0; i < AudienceSize; i++)
            {
                int index = random.Next(scores.Count);
                var v = scores[index];
                v.score++;
                scores[index] = v;
            }

            scores.Sort((x, y) => x.score > y.score ? -1 : 1); //ignoring tie
            Console.WriteLine($"Champion of the tornemant is {scores[0].Contestant.name} with {scores[0].score} votes out of {AudienceSize}");
        }
    }
}
