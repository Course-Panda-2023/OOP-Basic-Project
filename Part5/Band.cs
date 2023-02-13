using System;
class Band : Member
{
	private string mBandName;
	private string mSong;
    public string Song
    {
        get { return mSong; }
        set { mSong = value; }
    }
    public string Name
	{
		get { return mBandName; }
		set { mBandName = value; }
	}
	private Member[] mSingers;
	public Member[] Singers { get { return mSingers; }}
	public string BandName { get { return mBandName; }}
	public Band(Member[] singers, string song, string bandName)
	{
		//mSingers=new Singer[singers.Length];
		mSingers= singers;
		mSong= song;
		foreach(Member singer in mSingers)
		{
			singer.Song = song;
		}
		mBandName= bandName;
	}

    public void Performance()
    {
		Console.WriteLine($"*together in harmony:*\n{mBandName}:");
		foreach(Member member in mSingers)
		{
            member.Performance();
        }
    }
}
