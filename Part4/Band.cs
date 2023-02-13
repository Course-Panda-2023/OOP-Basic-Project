using System.Collections.Generic;

class Band : Competitor
{
    List<Singer> bandMembers;
    public Band(string name, List<Song> songs, int numOfFans, List<Singer> bandMembers) : base(name, songs, numOfFans)
    {
        this.bandMembers = bandMembers;
    }

    public void addMember(Singer member)
    {
        this.bandMembers.Add(member);
    }
    
    public void dispMembers()
    {
        string members = ""; 
        foreach (Singer singer in this.bandMembers) 
            members += $"{singer.name}, ";
            // Console.WriteLine();
        Console.WriteLine($"Band Members are: {members}");
    }
}