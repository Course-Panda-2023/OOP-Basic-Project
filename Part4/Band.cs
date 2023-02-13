using System;
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

    public void AddList(Song[] songs)
    {
        for (int i = 0; i < songs.Length; i++)
        {
            mSongs.Add(songs[i]);
        }
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

    public void PerformOneOfThree()
    {
        Random ran = new Random();
        if (mSongs.Count == 3)
        {
            int index = ran.Next(0, 3);
            Console.WriteLine($"Hello everyone, our name is {mName}!");
            Song song = mSongs[index];
            Console.WriteLine($"We will now be Performing: {song.Name} \n");
            foreach (Singer singer in mSingers)
            {
                singer.PerformSong(song);
            }
        }
    }

}
