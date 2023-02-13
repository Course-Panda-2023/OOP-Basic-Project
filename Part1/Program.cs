// See https://aka.ms/new-console-template for more information

/*
 * TODO: Write code for part1.
 * Notice: You need to implement the project structure yourself.
 */
using System;
namespace Music
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Music Empire");
            Console.WriteLine("**************************");


            // Create Judge instance
            Judge simonCowell = new Judge("Simon", "Cowell");

            Console.WriteLine($"The judge is {simonCowell}");


            // Create Singers' instances
            Singer cristinaAguilera = new Singer("Cristina", "Aguilera");
            Singer ladyGaga = new Singer("Lady", "Gaga");

            cristinaAguilera.Sing("Cristina Song");

            ladyGaga.Sing("Lady Song");

            Console.WriteLine("**************************");


            string winner = simonCowell.ChoiceWinner(cristinaAguilera, ladyGaga);

            Console.WriteLine($"The winner in the competition: {winner}");

            Console.WriteLine();
        }
    }   
}

