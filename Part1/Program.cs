// See https://aka.ms/new-console-template for more information
using OOPFinal;
using OOPFinal.MusicPeople;
using OOPFinal.Songs;

Singer christina = new Singer("Christina Aguilera");
Singer gaga = new Singer("Lady Gaga");
Judge simon = new Judge("Simon Cowell",
    "You didn't beat the compotition you crushed the compotition!",
    "You sounded like Dolly parton on helium. I only chose you because the other one was even worse.",
    "Don’t sing again. Both of you were terrible.");
Singer[] competitors = { christina, gaga };

Song christinaSong1 = new Song("Hurt", christina, "Seems like it was yesterday when I saw your face...");
Song gagaSong1 = new Song("Bloody Mary", gaga, "Love is just a history that they may prove...");

Console.WriteLine("Welcome to our singing competition!!\n");

Console.WriteLine($"The first singer {christina.Name} will sing \"{christinaSong1.Name}\".\n" +
    $"\"{christinaSong1.FirstLine}\"\n\n" +
    $"The second singer {gaga.Name} will sing \"{gagaSong1.Name}\".\n" +
    $"\"{gagaSong1.FirstLine}\"\n");

Random rnd = new Random();
int winner = rnd.Next(2);

Console.WriteLine($"The winner that {simon.Name} chose is.. {competitors[winner].Name}!\n" +
    $"Lets hear what {simon.Name} has to say about the winner's performance:\n" +
    $"\"{simon.GetUniqueResponse()}\"");
Console.ReadLine();