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

    public Singer ChooseWinner(SingingContest contest)
    {
        Random rand = new Random();
        List<Person> singerList = contest.getSingers();
        int winnerIndex = rand.Next(singerList.Count);
        Console.WriteLine($"judge {this.Name}: hmmm... the winner is {singerList[winnerIndex].Name}");
        return (Singer)singerList[winnerIndex];
    }
}
public class Program
{
    public static void Tournament(SingingContest c, Judge j)
    {
        SingingContest tournamentCopy = c;
        int round = 1;
        if (c.getSingers().Count % 2 != 0)
        {
            Console.WriteLine("number of singers not even");
            return;
        }
        else
        {
            while (tournamentCopy.getSingers().Count != 1)
            {
                Console.WriteLine($"Round {round}");
                List<Person> winners = new List<Person>();
                int numberOfSingers = c.getSingers().Count;
                for (int i = 0; i < numberOfSingers; i++)
                {
                    Singer singer1 = (Singer)tournamentCopy.getSingers()[i];
                    Singer singer2 = (Singer)tournamentCopy.getSingers()[i + 1];
                    Console.WriteLine($"Match {i / 2 + 1}: {singer1.Name} vs. {singer2.Name}");
                    SingingContest duel = new SingingContest(new List<Person> { singer1, singer2 });
                    duel.everyoneSing();
                    Singer winner = j.ChooseWinner(duel);
                    Console.WriteLine($"Winner: {winner.Name}\n");
                    tournamentCopy.removeSinger(singer1);
                    tournamentCopy.removeSinger(singer2);
                    winners.Add(winner);
                    if (numberOfSingers <= 0)
                    {
                        break;
                    }
                    else
                    {
                        numberOfSingers = tournamentCopy.getSingers().Count;
                    }

                }
                Console.WriteLine($"all winners of round {round}:");
                foreach (Singer s in winners)
                {
                    Console.WriteLine(s.Name);
                    tournamentCopy.addSinger(s);
                }
                round++;
            }
            Console.WriteLine($"Final round: {c.getSingers()[0].Name} is the winner!");
        }
    }

    public static void Main(string[] args)
    {
        SingingContest contest = new SingingContest();
        Judge j = new Judge("fluffy");
        contest.addSinger(new Singer("lady gaga"));
        contest.addSinger(new Singer("cristina"));
        contest.addSinger(new Singer("madonna"));
        contest.addSinger(new Singer("shakira"));
        contest.addSinger(new Singer("adele"));
        contest.addSinger(new Singer("lavin"));
        contest.addSinger(new Singer("nicki minaj"));
        contest.addSinger(new Singer("kesha"));
        contest.addSinger(new Singer("clarkson"));
        contest.addSinger(new Singer("katy perry"));
        contest.addSinger(new Singer("rihana"));
        contest.addSinger(new Singer("beyonce"));
        Tournament(contest, j);
    }
}

