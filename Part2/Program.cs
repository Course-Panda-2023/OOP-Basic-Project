using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;


class Program
{
    // public static List<Part1.Singer>  
    public static void Main(string[] args)
    {
        // Singer ChristinaAguilera = new Singer("Christina Aguilera", 42, new List<Song>(), 400000);
        // Singer LadyGaga = new Singer("Lady Gaga", 36, new List<Song>(), 500000);

        // LadyGaga.addSong(new Song("Bad Romance", 309, 2009, LadyGaga));
        // LadyGaga.addSong(new Song("Just Dance", 247, 2009, LadyGaga));

        // ChristinaAguilera.addSong(new Song("Beautiful", 240, 2001, ChristinaAguilera));
        // ChristinaAguilera.addSong(new Song("Lady Marmalade", 274, 2001, ChristinaAguilera));


        Judge SimonCowell = new Judge("Simon Cowell", 63);
        SingingCompetition2 singingCompetition = new SingingCompetition2(new List<Singer>(), SimonCowell);
        // singingCompetition.addSinger(ChristinaAguilera);
        // singingCompetition.addSinger(LadyGaga);
        
        for (int i=0; i<15; i++)
        {
            Singer singer = new Singer($"Singer {i}", 42, new List<Song>(), 400000);
            singingCompetition.addSinger(singer);
        }
        singingCompetition.RunCompetition();

    }

}