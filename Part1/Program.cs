using System;
using System.Collections.Generic;

public class Person
{
    public string Name { get; set; }
    public Person(string Name)
    {
        this.Name = Name;
    }
}
public class SingingContest
{
    public List<Person> singers;

    public SingingContest()
    {
        singers = new List<Person>();
    }

    public SingingContest(List<Person> singers)
    {
        this.singers = singers;
    }

    public void addSinger(Singer singer)
    {
        singers.Add(singer);
    }

    public void removeSinger(Singer singer)
    {
        singers.Remove(singer);
    }

    public List<Person> getSingers()
    {
        return singers;
    }

    public void everyoneSing()
    {
        string[] lyrics = { "its about drive its about power", "you've been hit by you've been struck by a smooth criminal",
                "we are the champions", "somebody once told me the world aint gonna roll me", "hey now you're an all star",
                "gangster rap"};
        Random rand = new Random();
        foreach (Singer s in singers)
        {
            s.sing(lyrics[rand.Next(lyrics.Length)]);
        }
    }
}
public class Singer : Person
{
    public Singer(string Name) : base(Name)
    {

    }

    public void sing(string lyric)
    {
        Console.WriteLine($"{this.Name}: {lyric}");
    }
}
public class Judge : Person
{
    public Judge(string Name) : base(Name)
    {

    }

    public void ChooseWinner(SingingContest contest)
    {
        Random rand = new Random();
        List<Person> singerList = contest.getSingers();
        Console.WriteLine($"judge {this.Name}: hmmm... the winner is {singerList[rand.Next(singerList.Count)].Name}");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        SingingContest contest = new SingingContest();
        Judge j = new Judge("fluffy");
        contest.addSinger(new Singer("lady gaga"));
        contest.addSinger(new Singer("cristina"));
        contest.everyoneSing();
        j.ChooseWinner(contest);
    }
}
