public class Band : Person
{
    public string BandName { get; set; }
    public List<Person> BandMembers;
    public Band(string BandName, List<Person> BandMembers) : base(BandName)
    {
        this.BandMembers = BandMembers;
    }
    public Boolean isBandValid()
    {
        int singerCounter = 0, drummerCounter = 0, guitaristCounter = 0;
        foreach (Person p in BandMembers)
        {
            if (p is Singer)
            {
                singerCounter++;
            }
            else if (p is Drummer)
            {
                drummerCounter++;
            }
            else if (p is Guitarist)
            {
                guitaristCounter++;
            }
        }
        if (singerCounter >= 1 && drummerCounter >= 1 && guitaristCounter >= 1)
        {
            return true;
        }
        return false;
    }
    public override void Sing(string lyric)
    {
        Random rand = new Random();
        int sharedIndex = rand.Next(lyrics.useLyrics.Length);
        foreach (Person p in BandMembers)
        {
            if(p is Singer)
            {
                p.Sing(lyrics.useLyrics[sharedIndex]);
            } else if (p is Musician)
            {
                p.PlayMusic();
            }
        }

    }

}

