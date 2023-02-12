using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Security;

class SingingCompetition2 : SingingCompetition
{
    
    public SingingCompetition2(List<Singer> singers, Judge judge) : base(singers, judge)
    {
        
        // TODO
    }

    public static List<Tuple<int, int>> IndexPairs(int len)
    {
        Random rand = new Random();
        List<int> indexes = new List<int>();
        for (int i=0; i<len; i++)
            indexes.Add(i);
        
        for(int i= indexes.Count - 1; i > 1; i--)
        {
            int rnd = rand.Next(i + 1);  

            int value = indexes[rnd];  
            indexes[rnd] = indexes[i];  
            indexes[i] = value;
        }
        // List<int> mixedIndexes = indexes.OrderBy(c => rand.Next()).ToList();
        
        List<Tuple<int, int>> pairs = new List<Tuple<int, int>>();
        // int advance = 0;
        while(indexes.Count != 0)
        {
            pairs.Add(new Tuple<int, int>(indexes[0], indexes[1]));
            indexes.RemoveAt(0);
            indexes.RemoveAt(0);
            // advance++;
        }
        return pairs;
    }

    public List<Singer> RunCompIteration(List<Singer> singers)
    {
        Random rand = new Random();
        int numCompetitors = singers.Count;
        List<Singer> Winners = new List<Singer>();
        if (numCompetitors % 2 != 0)
        {
            int winnerIndex = rand.Next(0, this.singers.Count);
            Console.WriteLine($"Competitor {singers[winnerIndex].name} proceeds technicality. (odd number of competitors)");
            Winners.Add(singers[winnerIndex]);
            singers.RemoveAt(winnerIndex);
        }
        List<Tuple<int, int>> pairs = IndexPairs(singers.Count);
        foreach (Tuple<int, int> pair in pairs)
        {
            Console.WriteLine($"Duel between: {singers[pair.Item1].name} and {singers[pair.Item2].name}.");
            int chosen;
            if (rand.Next(0,2) == 0)
                chosen = pair.Item1;
            else
                chosen = pair.Item2;
            Console.WriteLine($"{singers[chosen].name} won!");
            Winners.Add(singers[chosen]);

            Console.WriteLine("");

        }
        return Winners;



    }

    public override void RunCompetition()
    {
        
        List<Singer> currentSingers = new List<Singer>(this.singers);
        int roundNumber = 1;
        while (currentSingers.Count > 1)
        {
            Console.WriteLine($"Round {roundNumber} begins.");
            currentSingers = RunCompIteration(currentSingers);
            Console.WriteLine("The one that proceed are:");
            for (int i=0; i<currentSingers.Count; i++)
                Console.WriteLine(currentSingers[i].name);
            roundNumber++;
            Console.WriteLine("------------------------------");       
        }
        Console.WriteLine($"The winner is {currentSingers[0].name}!!!");
        
    }
}