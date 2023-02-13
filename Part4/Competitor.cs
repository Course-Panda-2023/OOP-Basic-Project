
abstract class Competitor
{
    public string? name {get;}

    public List<Song> songs = new List<Song>();
    private int numOfFans;

    public Competitor(string name, List<Song> songs, int numOfFans)
    {
        this.name = name;
        this.songs = songs;
        this.numOfFans = numOfFans;
    }
    
    public void addSong(Song song)
    {
        this.songs.Add(song);
    }
}
