using System;

class Singer : Member
{
    public Singer(string name, string song)
    {
        mName = name;
        mSong = song;
        mSongArray =new string[] { song};
    }
    public Singer(string name)
    {
        mName = name;
        mSong = null;
        mSongArray = new string[] { mSong };
    }
    private string mName;
    private string mSong;
    private string[] mSongArray;

    public Singer(string name, string[] songs)
    {
        mName = name;
        mSongArray = songs;
        int randIndex = new Random().Next(0, songs.Length); //randomly picks a song out of 3 songs to sing at the contest!
        mSong = songs[randIndex];
    }
    public string Song
    {
        get { return mSong; }
        set { mSong = value; }
    }

    public string Name
    {
        get { return mName; }
        set { mName = value; }
    }

    public string[] songList
    {
        get { return mSongArray; }
    }

    public void Performance()
    {
        Console.WriteLine($"{mName}: {mSong}");
    }
}