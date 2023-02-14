
abstract class Competitor
{
    public string Name {get;}

    public List<Song> Songs;
    private int NumOfFans;

    public Competitor(string name, List<Song> songs, int numOfFans)
    {
        this.Name = name;
        this.Songs = songs;
        this.NumOfFans = numOfFans;
    }
    
    public void AddSong(Song song)
    {
        this.Songs.Add(song);
    }
    public abstract bool IsValid();
    
}
