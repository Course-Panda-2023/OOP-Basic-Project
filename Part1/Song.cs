class Song
{
    private string mName;
    public string Name 
    {
        get { return mName; }
        set { mName = value; } 
    }

    public string mLyrics;
    public string lyrics
    {
        get { return mLyrics; }
        set { mLyrics = value; }
    }

    public Song(string name, string lyrics)
    {
        mName = name;   
        mLyrics = lyrics;
    }
}