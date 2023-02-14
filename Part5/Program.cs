// See https://aka.ms/new-console-template for more information

/*
 * TODO: Copy all of your code from part4 and continue here.
 */
namespace Music
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathFileCompetitors = @"C:\Users\mamag3\Desktop\AmitNadam\OOP-Basic-Project\Part5\competitors.txt";
            string pathFileSongs = @"C:\Users\mamag3\Desktop\AmitNadam\OOP-Basic-Project\Part5\songs.txt";

            Judge simonCowell = new Judge("Simon Cowell");

            Console.WriteLine("Type the number of Crowd:");
            int numberOfcrowd = int.Parse(Console.ReadLine());

            Competition competition = new Competition(simonCowell, pathFileCompetitors, pathFileSongs, numberOfcrowd);

            competition.Start();

            Console.WriteLine();
        }
    }
}