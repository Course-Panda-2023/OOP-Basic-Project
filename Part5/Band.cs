using System.Collections.Generic;

class Band : Competitor
{
    public List<Singer> Singers;
    public Band(string name, List<Song> songs, int numOfFans, List<Singer> singers) : base(name, songs, numOfFans)
    {
        this.Singers = singers;
    }

    public void AddMember(Singer member)
    {
        this.Singers.Add(member);
    }
    
    public void DispMembers()
    {
        Console.Write($"Band members are: ");
        foreach (Singer singer in this.Singers) 
            Console.Write($"{singer.Name}, ");
            // Console.WriteLine();
        Console.WriteLine();
    }

    public override bool IsValid()
    {
        if (this.Songs.Count == 0)
        {
            Console.WriteLine("Band has no songs");
            return false;
        }
        else
            return true;
    }
}