
class RockBand : Band
{
    List<Guitarist> guitarists;
    List<Drummer> drummers;
    public RockBand(string name, List<Song> songs, int numOfFans, List<Singer> singers, List<Guitarist> guitarists, List<Drummer> drummers) : base(name, songs, numOfFans, singers)
    {
        // Create instance only if there is at least one singer, one guitarist and one drummer.
        if (singers.Count == 0 || guitarists.Count == 0 || drummers.Count == 0)
        {
            throw new ArgumentException("Members don't meet criteria.");
        }
        this.guitarists = guitarists;
        this.drummers = drummers;
    }

     
    public override void dispMembers()
    {
        string members = ""; 
        foreach (Singer singer in this.singers) 
            members += $"{singer.name}(singer), ";
        foreach (Guitarist guitarist in this.guitarists) 
            members += $"{guitarist.name}(guitarist), ";
        foreach (Drummer drummer in this.drummers) 
            members += $"{drummer.name}(drummer), ";
        
        Console.WriteLine($"Band members are: {members}");
    }
}