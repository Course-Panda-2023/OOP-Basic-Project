class Singer
{
    public enum VocalRange
    {
        Soprano,
        Alt,
        Tenor,
        Bass
    }

    private string mName;
    public string Name 
    { 
        get { return mName; }
        set { mName = value; }
    }

    private string mGenre;
    public string Genre
    {
        get { return mGenre; }
        set { mGenre = value; }
    }

    private VocalRange mRange;
    public VocalRange Range
    {
        get { return mRange; }
        set { mRange = value; }
    }

    private List<Song> mSongs;
    public List<Song> Songs
    {
        get { return mSongs; }
        set { mSongs = value; }
    }
        
    public Singer(string name, string genre, VocalRange range)
    {
        mName= name;
        mGenre= genre;
        mRange= range;
        mSongs = new List<Song>();
    }

    public void AddSong(Song song)
    {
        mSongs.Add(song);
    }

    public void Perform()
    {
        Console.WriteLine($"Hello everyone, my name is {mName}!");
        foreach (Song song in mSongs)
        {
            Console.WriteLine($"I will now be performing {song.Name}: \n");
            Console.WriteLine(song.lyrics + "\n");
        }
    }

}