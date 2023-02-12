using System;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Security;

class SingingCompetition3 : SingingCompetition
{
    List<Person> voters;
    public SingingCompetition3(List<Singer> singers, Judge judge, List<Person> voters) : base(singers, judge)
    {
        this.voters = voters;
    }

    public void addVoter(Person voter)
    {
        this.voters.Add(voter);
    }

    public override void RunCompetition()
    {
        Random rand = new Random();
        
        // Singers choosing songs
        foreach (Singer singer in this.singers)
        {
            int chosenSongNumber = rand.Next(0, 3); 
            Console.WriteLine($"{singer.name} chose to sing the song: {singer.songs[chosenSongNumber].name}");
        }

        // Voters voting for singers
        int numOfSingers = this.singers.Count;
        SortedDictionary<int, int> votes = new SortedDictionary<int, int>();        
        int singerVote;
        foreach (Person voter in this.voters)
        {
            singerVote = rand.Next(0, numOfSingers);
            if (votes.ContainsKey(singerVote))
                votes[singerVote]++;
            else
                votes[singerVote] = 1;
        }

        // results
        int maxVotes = 0;
        Singer chosenSinger = this.singers[0];
        foreach(KeyValuePair<int, int> entry in votes)
        {
            int numVotes = entry.Value;
            Singer singer = this.singers[entry.Key];
            Console.WriteLine($"{singer.name} got {numVotes}.");
            if (numVotes > maxVotes)
            {
                maxVotes = numVotes;
                chosenSinger = singer;
            }
        }

        // Winner
        Console.WriteLine($"And So the winner is: {chosenSinger.name}");

    }
}