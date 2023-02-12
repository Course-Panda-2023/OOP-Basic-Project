﻿class MainClass
{
    public static void Main(string[] args)
    {
        Song c1 = new Song("Beautiful");
        Song c2 = new Song("Genie in a Bottle");
        Song c3 = new Song("Hurt");
        Song lg1 = new Song("Bad Romance");
        Song lg2 = new Song("Shallow");
        Song lg3 = new Song("Poker Face");
        List<Song> christinaSongsList = new List<Song>() { c1, c2, c3 };
        List<Song> ladyGagaSongsList = new List<Song>() { lg1, lg2, lg3 };
        Judge simon = new Judge("Simon");
        Singer ladyGaga = new Singer("Lady Gaga", ladyGagaSongsList);
        Singer christinaAguilera = new Singer("Christina Aguilera", christinaSongsList);
        Contest contest = new Contest(simon, ladyGaga, christinaAguilera);
        contest.SimulateRound();
        Console.WriteLine();
        contest.SimulateRound();
        Console.WriteLine();
        contest.PrintLeadingSinger();
    }
}