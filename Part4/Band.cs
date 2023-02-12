using System.Collections.Generic;

class Band : Performer
{
    private string mName;
    public string Name
    {
        get { return mName; }
        set { mName = value; }
    }

    private Singer[] mSingers;
    public Singer[] Singers
    {
        get { return mSingers; }
        set { mSingers = value; }
    }

    private List<Song> mSongs;
    public List<Song> Songs
    {
        get { return mSongs; }
        set { mSongs = value; }
    }

    public Band(string name, Singer[] singers)
    {
        mName = name;
        mSingers = singers;
        mSongs = new List<Song>();
    }

    public void AddSong(Song song)
    {
        mSongs.Add(song);
    }

    public void Perform()
    {
        Console.WriteLine($"Greatings! We are: {mName} \n");
        foreach (Song song in mSongs)
        {
            Console.WriteLine($"We will now be Performing: {song.Name} \n");
            foreach (Singer singer in mSingers)
            {
                singer.PerformSong(song);
            }
        }
    }
    
}
