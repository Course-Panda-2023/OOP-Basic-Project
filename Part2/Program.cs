// See https://aka.ms/new-console-template for more information

/*
 * TODO: Copy all of your code from part1 and continue here.
 */
using System.Text.Json;
namespace Music
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathFileSingers = @"C:\\Users\\mamag3\\Desktop\\AmitNadam\\OOP-Basic-Project\\Part2\\singers.txt";
            string pathFileSongs = @"C:\\Users\\mamag3\\Desktop\\AmitNadam\\OOP-Basic-Project\\Part2\\songs.txt";
            Judge simonCowell = new Judge("Simon Cowell");

            Competition competition = new Competition(simonCowell, pathFileSingers, pathFileSongs);

            competition.Start();

            Console.WriteLine();
        }
    }
}