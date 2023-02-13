using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

class Program
{
    // public static List<Part1.Singer>  
    public static void Main(string[] args)
    {
        Song song1 = new Song("Song1", 240, 2020, new Person("Writer 1", 25));
        Song song2 = new Song("Song2", 200, 2010, new Person("Writer 2", 30));
        Song song3 = new Song("Song3", 220, 2016, new Person("Writer 3", 35));

        SingingCompetition4 singingCompetition = new SingingCompetition4(new List<Competitor>(), new List<Person>());

        List<Song> songList = new List<Song>();
        songList.Add(song1);
        songList.Add(song2);
        songList.Add(song3);

        Random rand = new Random();
        int minAge = 20;
        int maxAge = 41;

        Console.WriteLine("Enter numebr of Competitors");
        int numCompetitors = Convert.ToInt32(Console.ReadLine());

        int numOfFans; 
        for (int i=0; i<numCompetitors; i++)
        {
            numOfFans = rand.Next(0, 1000000);
            if  (i % 2 == 0)
            {
                List<Singer> bandMembers = new List<Singer>();
                Singer singer1 = new Singer($"Member B{i/2+1}-M{1}", songList, numOfFans/3, (uint)rand.Next(minAge, maxAge));
                Singer singer2 = new Singer($"Member B{i/2+1}-M{2}", songList, numOfFans/3, (uint)rand.Next(minAge, maxAge));
                Singer singer3 = new Singer($"Member B{i/2+1}-M{3}", songList, numOfFans/3, (uint)rand.Next(minAge, maxAge));
                bandMembers.Add(singer1);
                bandMembers.Add(singer2);
                bandMembers.Add(singer3);

                Competitor competitor = new Band($"Band {i/2+1}", songList, numOfFans, bandMembers);
                singingCompetition.addCompetitor(competitor);
            }
            else
            {
                Competitor competitor = new Singer($"Singer S{i/2+1}", songList, numOfFans, (uint)rand.Next(minAge, maxAge));
                singingCompetition.addCompetitor(competitor);                
            }
            
        }

        Console.WriteLine("Enter numebr of voters");
        int numVoters = Convert.ToInt32(Console.ReadLine());
        for (int i=0; i<numVoters; i++)
        {
            Person voter = new Person($"Voter {i}", (uint)rand.Next(minAge, maxAge));
            singingCompetition.addVoter(voter);
        }
        
        singingCompetition.RunCompetition();

    }

}
