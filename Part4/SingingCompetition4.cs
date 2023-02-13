using System;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Security;

class SingingCompetition4
{
    Random rand = new Random();
    public List<Competitor> competitors;
    List<Person> voters;

    public SingingCompetition4(List<Competitor> competitors, List<Person> voters) 
    {
        this.competitors = competitors;
        this.voters = voters;
    }

    public Competitor this[int index]
    {
        get {return competitors[index];}
        set {competitors[index] = value;}
    }

    public void addCompetitor(Competitor competitor)
    {
        this.competitors.Add(competitor);
    }
    
    public void addVoter(Person voter)
    {
        this.voters.Add(voter);
    }

    public void RunCompetition()
    {
        Random rand = new Random();
        
        // Competitors choosing songs
        foreach (Competitor competitor in this.competitors)
        {
            int chosenSongNumber = rand.Next(0, 3); 
            Console.WriteLine($"{competitor.name} chose to sing the song: {competitor.songs[chosenSongNumber].name}");
        }

        // Voters voting for singers
        int numOfCompetitors = this.competitors.Count;
        SortedDictionary<int, int> votes = new SortedDictionary<int, int>();        
        int competitorVote;
        foreach (Person voter in this.voters)
        {
            competitorVote = rand.Next(0, numOfCompetitors);
            if (votes.ContainsKey(competitorVote))
                votes[competitorVote]++;
            else
                votes[competitorVote] = 1;
        }

        // results
        int maxVotes = 0;
        Competitor chosenCompetitor = this.competitors[0];
        foreach(KeyValuePair<int, int> entry in votes)
        {
            int numVotes = entry.Value;
            Competitor competitor = this.competitors[entry.Key];
            Console.WriteLine($"{competitor.name} got {numVotes} votes.");
            if (numVotes > maxVotes)
            {
                maxVotes = numVotes;
                chosenCompetitor = competitor;
            }
        }

        // Winner
        Console.WriteLine($"And so, the winner is: {chosenCompetitor.name}");

    }
}