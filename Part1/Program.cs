// See https://aka.ms/new-console-template for more information

/*
* TODO: Write code for part1.
* Notice: You need to implement the project structure yourself.
*/
using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("run test");
        Singer ChristinaAguilera = new Singer("Christina Aguilera", 42, new List<Song>(), 400000);
        Singer LadyGaga = new Singer("Lady Gaga", 36, new List<Song>(), 500000);

        LadyGaga.addSong(new Song("Bad Romance", 309, 2009, LadyGaga));
        LadyGaga.addSong(new Song("Just Dance", 247, 2009, LadyGaga));

        ChristinaAguilera.addSong(new Song("Beautiful", 240, 2001, ChristinaAguilera));
        ChristinaAguilera.addSong(new Song("Lady Marmalade", 274, 2001, ChristinaAguilera));

        Judge SimonCowell = new Judge("Simon Cowell", 63);
        SingingCompetition singingCompetition = new SingingCompetition(new List<Singer>(), SimonCowell);
        
        singingCompetition.addSinger(ChristinaAguilera);
        singingCompetition.addSinger(LadyGaga);
        
        singingCompetition.RunCompetition();


    }

}
