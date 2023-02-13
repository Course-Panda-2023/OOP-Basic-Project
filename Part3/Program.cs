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

        SingingCompetition3 singingCompetition = new SingingCompetition3(new List<Singer>(), new Judge("", 0), new List<Person>());
        // singingCompetition.addSinger(ChristinaAguilera);
        // singingCompetition.addSinger(LadyGaga);
        List<Song> songList = new List<Song>();
        songList.Add(song1);
        songList.Add(song2);
        songList.Add(song3);

        Random rand = new Random();
        int minAge = 20;
        int maxAge = 41;

        Console.WriteLine("Enter numebr of singers");
        int numSingers = Convert.ToInt32(Console.ReadLine());

        for (int i=0; i<numSingers; i++)
        {

            Singer singer = new Singer($"Singer {i}", (uint)rand.Next(minAge, maxAge), songList, 400000);
            singingCompetition.addSinger(singer);
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
