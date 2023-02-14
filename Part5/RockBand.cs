
class RockBand : Band
{
    List<Guitarist> Guitarists;
    List<Drummer> Drummers;
    public RockBand(string name, List<Song> songs, int numOfFans, List<Singer> singers, List<Guitarist> guitarists, List<Drummer> drummers) : base(name, songs, numOfFans, singers)
    {        
        this.Guitarists = guitarists;
        this.Drummers = drummers;
    }

    public override bool IsValid()
    {
        if (this.Singers.Count == 0 || this.Guitarists.Count == 0 || this.Drummers.Count == 0)
        {
            Console.WriteLine("Band missing at least one singer/guitarist/drummer");
            return false;
        }
        else if (this.Songs.Count == 0)
        {
            Console.WriteLine("Band has no songs");
            return false;
        }
        else
            return true;
    }
     
    public new void DispMembers()
    {
        Console.Write($"Band members are: ");
        foreach (Singer singer in this.Singers) 
        {
            Console.Write($"{singer.Name}(singer), ");
        }
        foreach (Guitarist guitarist in this.Guitarists) 
        {
            Console.Write($"{guitarist.Name}(guitarist), ");
        }
        foreach (Drummer drummer in this.Drummers) 
        {
            Console.Write($"{drummer.Name}(drummer), ");
        }
        Console.WriteLine();
    }
}