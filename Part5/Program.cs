using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

class Program
{
    public static void Main(string[] args)
    {
        Random rand = new Random();
        int minAge = 20;
        int maxAge = 41;
        int numOfFans = rand.Next(0, 1000000);
        Singer singer = new Singer($"Lina", new List<Song>(), numOfFans/3, (uint)rand.Next(minAge, maxAge));
        Guitarist guitarist = new Guitarist($"Erez", (uint)rand.Next(minAge, maxAge), GuitarType.Acoustic);
        Drummer drummer = new Drummer($"Shimon", (uint)rand.Next(minAge, maxAge));
        List<Singer> singers = new List<Singer>();
        singers.Add(singer);
        List<Guitarist> guitarists = new List<Guitarist>();
        guitarists.Add(guitarist);
        List<Drummer> drummers = new List<Drummer>();
        drummers.Add(drummer);

        // fails cause no drummers
        // RockBand rockBand = new RockBand("Shimon Park", new List<Song>(), numOfFans, singers, guitarists, new List<Drummer>());
        
        // succeeds
        RockBand rockBand = new RockBand("Shimon Park", new List<Song>(), numOfFans, singers, guitarists, drummers);
        rockBand.dispMembers();
    }

}
