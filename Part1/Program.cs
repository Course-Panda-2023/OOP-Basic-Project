using System;
using System.Collections.Generic;

public class lyrics
{
    public static string[] useLyrics =
    {
        "its about drive its about power",
        "you've been hit by you've been struck by a smooth criminal",
        "we are the champions",
        "somebody once told me the world aint gonna roll me",
        "hey now you're an all star",
        "gangster rap",
        "im blue da ba de da ba da",
        "im the slim shady",
        "hi my name is",
        "ah sama lama dua bua"
    };
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
                    Person singer1 = tournamentCopy.getSingers()[i];
                    Person singer2 = tournamentCopy.getSingers()[i + 1];
                    Console.WriteLine($"Match {i + 1}: {singer1.Name} vs. {singer2.Name}");
                    SingingContest duel = new SingingContest(new List<Person> { singer1, singer2 });
                    duel.everyoneSing();
                    Person winner = j.ChooseWinner(duel);
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
                Console.WriteLine();
            }
            Console.WriteLine($"Final round: {c.getSingers()[0].Name} is the winner!");
        }
    }

    public static void CrowdTournament(SingingContest c, Judge j, int MaxVotes)
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
                    Person singer1 = tournamentCopy.getSingers()[i];
                    Person singer2 = tournamentCopy.getSingers()[i + 1];
                    int p1votes = 0, p2votes = 0;
                    Console.WriteLine($"Match {i + 1}: {singer1.Name} vs. {singer2.Name}");
                    SingingContest duel = new SingingContest(new List<Person> { singer1, singer2 });
                    duel.everyoneSing();
                    for (int k = 0; k < MaxVotes; k++)
                    {
                        Console.WriteLine($"cast your votes! 1 for {singer1.Name}, 2 for {singer2.Name}");
                        int choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                p1votes++;
                                break;
                            case 2:
                                p2votes++;
                                break;
                            default:
                                break;
                        }
                    }
                    Person winner;
                    if (p1votes > p2votes)
                    {
                        winner = singer1;
                    }
                    else if (p1votes < p2votes)
                    {
                        winner = singer2;
                    }
                    else
                    {
                        winner = j.ChooseWinner(duel); //winner gets chosen randomly by judge
                    }
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
                foreach (Person s in winners)
                {
                    Console.WriteLine(s.Name);
                    tournamentCopy.addSinger(s);
                }
                Console.WriteLine();
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
        //contest.addSinger(new Singer("rihana"));
        //contest.addSinger(new Singer("beyonce"));

        List<Person> BandMembers1 = new List<Person>() { new Singer("memelord"), new Drummer("yo"), new Guitarist("guitar man"), new Guitarist("good guitar") };
        List<Person> BandMembers2 = new List<Person>() { new Singer("evil god"), new Drummer("hehehyo"), new Guitarist("evil guitar man") };
        Band b1 = new Band("the good people", BandMembers1);
        Band b2 = new Band("the evil people", BandMembers2);
        contest.addBand(b1);
        contest.addBand(b2);
        //contest.everyoneSing();
        //j.ChooseWinner(contest);
        CrowdTournament(contest, j, 5);
    }
}


