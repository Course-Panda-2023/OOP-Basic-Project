public class SingingContest
{
    public List<Person> Contestants;

    public SingingContest()
    {
        Contestants = new List<Person>();
    }

    public SingingContest(List<Person> singers)
    {
        this.Contestants = singers;
    }

    public void addSinger(Person singer)
    {
        Contestants.Add(singer);
    }

    public void removeSinger(Person singer)
    {
        Contestants.Remove(singer);
    }

    public void addBand(Band band)
    {
        if(band.isBandValid())
        {
            Contestants.Add(band);
        } else
        {
            Console.WriteLine("Band not valid");
        }
    }

    public void removeBand(Band band)
    {
        Contestants.Remove(band);
    }


    public List<Person> getSingers()
    {
        return Contestants;
    }



    public void everyoneSing()
    {
        //string[] lyrics = { "its about drive its about power", "you've been hit by you've been struck by a smooth criminal",
        //        "we are the champions", "somebody once told me the world aint gonna roll me", "hey now you're an all star",
        //        "gangster rap"};
        string[] newLyrics = lyrics.useLyrics;
        Random rand = new Random();
        foreach (Person s in Contestants)
        {
            s.Sing(newLyrics[rand.Next(newLyrics.Length)]);
        }
    }
}

