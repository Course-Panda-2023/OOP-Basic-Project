﻿using Microsoft.VisualBasic;
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

    public string MultiOpponentsContest( Singer[] singers)
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

    public Member CalcWinner(int crowd, List<Member> tie,int numOfWinners)
    {
        if (numOfWinners == 1)
        {
            return tie[0];
        }
        int[] count = new int[tie.Count];
        numOfWinners = 0;

        for (int i = 0; i < crowd; i++)
        {
            int randVote = new Random().Next(0, tie.Count);
            count[randVote] += 1;
        }
        List<Member> newTie = new List<Member>();
        int max = count.Max();
        for (int i = 0; i < count.Length; i++)
            if (count[i] == max)
            {
                numOfWinners++;
                newTie.Add(tie[i]);
            }
        return CalcWinner(crowd, newTie, numOfWinners);
    }

        


    
    public void CrowdsChoice(int crowd, Member[] singers)
    {
       int[] count = new int[crowd];
       List<Member> tie = new List<Member>();
       foreach (Member m in singers)
        {
            //My program already picks the random song out of 3 in the constructor phase but i just wanted to show that the random song can be picked at the competition stage as well
            /*
            int randIndex = new Random().Next(0, singer.songList.Length); //randomly picks a song out of 3 songs to sing at the contest!
            Console.WriteLine($"{singer.Name}: {singer.songList[randIndex]}");
            */
            m.Performance();
        }

        Console.WriteLine("now for the crowd votes!");
        for (int i = 0; i < singers.Length; i++)
        {
            tie.Add(singers[i]);
        }


        Member winner = CalcWinner(crowd,tie,0);
        //Console.WriteLine($"The winner is... {singers[count.ToList().IndexOf(maxValue)].Name}, with {maxValue} votes, out of {crowd}!!!");
        Console.WriteLine($"The winner is... {winner.Name}!!!");
    }




}
