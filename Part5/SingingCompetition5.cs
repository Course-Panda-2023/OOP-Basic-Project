using System;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Security;

class SingingCompetition5
{
    Random rand = new Random();
    public List<Competitor> Competitors;
    List<Person> Voters;

    public SingingCompetition5(List<Competitor> competitors, List<Person> voters) 
    {
        this.Competitors = competitors;
        this.Voters = voters;
    }

    public Competitor this[int index]
    {
        get {return Competitors[index];}
        set {Competitors[index] = value;}
    }

    public void AddCompetitor(Competitor competitor)
    {
        if (competitor.IsValid())
        {
            this.Competitors.Add(competitor);
        }
    }
    
    public void AddVoter(Person voter)
    {
        this.Voters.Add(voter);
    }

    private void CompetitorsPerfrom()
    {
        foreach (Competitor competitor in this.Competitors)
        {
            int chosenSongNumber = rand.Next(0, 3); 
            Console.WriteLine($"{competitor.Name} chose to sing the song: {competitor.Songs[chosenSongNumber].Name}");
        }
    }

    private SortedDictionary<int, int> Voting()
    {
        int numOfCompetitors = this.Competitors.Count;
        SortedDictionary<int, int> votes = new SortedDictionary<int, int>();        
        int competitorVote;
        foreach (Person voter in this.Voters)
        {
            competitorVote = rand.Next(0, numOfCompetitors);
            if (votes.ContainsKey(competitorVote))
                votes[competitorVote]++;
            else
                votes[competitorVote] = 1;
        }
        return votes;
    }

    private Competitor ChooseWinner(SortedDictionary<int, int> votes)
    {
        int maxVotes = 0;
        Competitor chosenCompetitor = this.Competitors[0];
        foreach(KeyValuePair<int, int> entry in votes)
        {
            int numVotes = entry.Value;
            Competitor competitor = this.Competitors[entry.Key];
            Console.WriteLine($"{competitor.Name} got {numVotes} votes.");
            if (numVotes > maxVotes)
            {
                maxVotes = numVotes;
                chosenCompetitor = competitor;
            }
        }
        return chosenCompetitor;
    }

    public void RunCompetition()
    {
        this.CompetitorsPerfrom();

        SortedDictionary<int, int> votes = this.Voting();
        
        Competitor chosenCompetitor = this.ChooseWinner(votes);
        
        Console.WriteLine($"And so, the winner is: {chosenCompetitor.Name}");

    }
}