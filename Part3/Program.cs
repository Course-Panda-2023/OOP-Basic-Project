// See https://aka.ms/new-console-template for more information

/*
 * TODO: Copy all of your code from part2 and continue here.
 */
using System.Text.Json;
namespace Music
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathFileSingers = @"C:\Users\mamag3\Desktop\AmitNadam\OOP-Basic-Project\Part3\singers.txt";
            string pathFileSongs = @"C:\Users\mamag3\Desktop\AmitNadam\OOP-Basic-Project\Part3\songs.txt";
           
            Judge simonCowell = new Judge("Simon Cowell");

            Console.WriteLine("Type the number of Crowd:");
            int numberOfcrowd = int.Parse(Console.ReadLine());

            Competition competition = new Competition(simonCowell, pathFileSingers, pathFileSongs, numberOfcrowd);

            competition.Start();

            Console.WriteLine();
        }
    }
}