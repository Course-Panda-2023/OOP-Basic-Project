using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

class Judge
{
    private string mName;
    private string[] mDescription;

    public Judge(string name)
    {
        mName = name;
        mDescription = new string[5];
        mDescription[0] = "That was quite a performance!";
        mDescription[1] = "i love that song so much, you sang it really good";
        mDescription[2] = "you are the next pop star";
        mDescription[3] = "i will build you a career just like i did with one direction";
        mDescription[3] = "im speechless";
    }
    public string Name
    {
        get { return mName; }
        set { mName = value; }
    }

    public Singer StartContest(Singer first, Singer two)
    {
        List<Singer> singers = new List<Singer>();
        singers.Add(first);
        singers.Add(two);
        Console.WriteLine($"Welcome to Mamas Idol! The best singing contest. I am {mName} your host.\n" +
            $"Today we will welcome two amazing singers: the one and only {first.Name} and the amazing {two.Name}!\n LETS BEGIN \n");
        foreach (Singer singer in singers)
        {
            Console.WriteLine($"Ladies and gentelmen, please welcome {singer.Name}!!");
            Console.WriteLine($" performance: {singer.Song}");
            Random randomInd = new Random();
            Console.WriteLine($"{mName}: {mDescription[randomInd.Next(0, 5)]}\n");
        }
        Random random = new Random();
        Singer winner = singers[random.Next(0, 2)];

        Console.WriteLine($"\n{mName}: Wow... in all my days as a judge this was something else. It was very hard to decide\n but i think we have a winner!\n the winner is.... *suspention*..\n{winner.Name}");
        return winner;
    }

    public string MultiOpponentsContest(params Singer[] singers)
    {
        List<Singer> losers = new List<Singer>();
        int index = 0;
        string winner ="";
        while (index < singers.Length - 2)
        {
            index++;
            
            Console.WriteLine($"\n\n\n\n\n\n\nRound {index}:\n");
            Random random1 = new Random();
            Random random2 = new Random();
            int intRandom1 = random1.Next(0,singers.Length);
            while(losers.Count!=0 && losers.Contains(singers[intRandom1]) == true)
            {
                intRandom1 = random1.Next(0, singers.Length);
            }
            int intRandom2 = random2.Next(0, singers.Length);
            while (intRandom1 == intRandom2 || (losers.Count!=0 && losers.Contains(singers[intRandom2]) == true))
            {
                intRandom2 = random2.Next(0, singers.Length);
            }
            Singer first = singers[intRandom1];
            Singer second = singers[intRandom2];
            winner = StartContest(first, second).Name;
            if(first.Name==winner)
            {
                losers.Add(second);
                Console.WriteLine($"bye bye to our loser: {second.Name}");
            }
            else
            {
                losers.Add(first);
                Console.WriteLine($"bye bye to our loser: {first.Name}");
            }

        }
        Console.WriteLine($"\n... and the overall winner is: {winner}");
        return winner;

    }
}
