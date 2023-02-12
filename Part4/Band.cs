using System;
class Band : Member
{
	private Singer[] mSingers;
	public Singer[] Singers { get { return mSingers; }}
	public Band(Singer[] singers, string song)
	{
		//mSingers=new Singer[singers.Length];
		mSingers= singers;
		foreach(Singer singer in mSingers)
		{
			singer.Song = song;
		}
	}

    public void Performance()
    {
		Console.WriteLine("*together in harmony:*");
		foreach(Singer singer in mSingers)
		{
            Console.WriteLine($"{singer.Name}: {singer.Song}");
        }
    }
}
