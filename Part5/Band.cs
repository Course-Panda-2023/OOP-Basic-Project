using System.Collections.Generic;

class Band : Competitor
{
    public List<Singer> singers;
    public Band(string name, List<Song> songs, int numOfFans, List<Singer> singers) : base(name, songs, numOfFans)
    {
        this.singers = singers;
    }

    public void addMember(Singer member)
    {
        this.singers.Add(member);
    }
    
    public virtual void dispMembers()
    {
        string members = ""; 
        foreach (Singer singer in this.singers) 
            members += $"{singer.name}, ";
            // Console.WriteLine();
        Console.WriteLine($"Band Members are: {members}");
    }
}