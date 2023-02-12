using System;

class Singer
{
    public Singer(string name, string song)
    {
        mName = name;
        mSong = song;
    }
    private string mName;
    private string mSong;

    public string Song
    {
        get { return mSong; }
        set { mName = value; }
    }

    public string Name
    {
        get { return mName; }
        set { mName = value; }
    }


}