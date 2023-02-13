using System;

class Guitarist : Performer
{
    private string mName;
    public string Name
    {
        get { return mName; }
        set { mName = value; }
    }

    private List<Song> mSongs;
    public List<Song> Songs
    {
        get { return mSongs; }
        set { mSongs = value; }
    }

    public void AddSong(Song song)
    {
        mSongs.Add(song);
    }

    public void AddList(Song[] songs)
    {
        for (int i = 0; i < songs.Length; i++)
        {
            mSongs.Add(songs[i]);
        }
    }

    public Guitarist(string name)
    {
        mName = name;
        mSongs = new List<Song>();
    }

    public void Perform()
    {
        Console.WriteLine($"Hello everyone, my name is {mName}!");
        foreach (Song song in mSongs)
        {
            Console.WriteLine($"I will now be performing {song.Name}: \n");
            Console.WriteLine($"*{song.Name} on guitar*");
        }
    }
    public void PerformOneOfThree()
    {
        Random ran = new Random();
        if (mSongs.Count == 3)
        {
            int index = ran.Next(0, 3);
            Console.WriteLine($"Hello everyone, my name is {mName}!");
            Song song = mSongs[index];
            Console.WriteLine($"I will now be performing {song.Name}: \n");
            Console.WriteLine($"*{song.Name} on guitar*");
        }
    }

    public void PerformSong(Song song)
    {
        Console.WriteLine(mName + ": " + song.Name + "\n");
    }
}
