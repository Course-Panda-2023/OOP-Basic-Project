using System;
class Band : Member
{
	private string mBandName;
	public string Name
	{
		get { return mBandName; }
		set { mBandName = value; }
	}
	private Singer[] mSingers;
	public Singer[] Singers { get { return mSingers; }}
	public string BandName { get { return mBandName; }}
	public Band(Singer[] singers, string song, string bandName)
	{
		//mSingers=new Singer[singers.Length];
		mSingers= singers;
		foreach(Singer singer in mSingers)
		{
			singer.Song = song;
		}
		mBandName= bandName;
	}

    public void Performance()
    {
		Console.WriteLine($"*together in harmony:*\n{mBandName}:");
		foreach(Singer singer in mSingers)
		{
            Console.WriteLine($"{singer.Name}: {singer.Song}");
        }
    }
}
