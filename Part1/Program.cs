// See https://aka.ms/new-console-template for more information
using OopFinal;

Console.WriteLine("Hello, World!");
Judge judge = new Judge("Simon Cowell");
Singer singer1 = new Singer("Lady Gaga");
Singer singer2 = new Singer("Christina Aguilera");
Singer singer3 = new Singer("Britney Spears");
Singer singer4 = new Singer("Madonna");
Singer singer5 = new Singer("Shakira");
Singer singer6 = new Singer("Adel");
Singer singer7 = new Singer("Avril Lavigne");
Singer singer8 = new Singer("Nicki Minaj");
Singer singer9 = new Singer("Ke$ha");
Singer singer10 = new Singer("Kelly Clarkson");
Singer singer11 = new Singer("Katy Perry");
Singer singer12 = new Singer("Rihanna");
Singer singer13 = new Singer("Beyonce");
Singer singer14 = new Singer("Justin bieber");
List<Singer> list = new List<Singer>() {singer1, singer2, singer3, singer4, singer5, singer6, singer7, singer8, singer9, singer10, singer11, singer12,singer13,singer14};


Competition myCompetition = new Competition(list, judge);
myCompetition.compete();
Console.ReadLine();