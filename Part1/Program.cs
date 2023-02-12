// See https://aka.ms/new-console-template for more information
using OopFinal;

Console.WriteLine("Hello, World!");
Judge simon = new Judge("Simon Cowell");
Singer gaga = new Singer("Lady Gaga");
Singer christina = new Singer("Christina Aguilera");
Competition myCompetition = new Competition(christina, gaga, simon);
myCompetition.compete();
Console.ReadLine();
