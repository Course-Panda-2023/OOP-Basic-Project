// See https://aka.ms/new-console-template for more information

using OOPFinal;
using OOPFinal.Competitions;
using OOPFinal.MusicPeople;
using OOPFinal.MusicPeople.Participants;
using OOPFinal.Songs;

Song song1 = new Song("The Fox (What Does the Fox Say?)", "Dog goes \"woof\"...");
Song song2 = new Song("Thriller", "It's close to midnight...");
Song song3 = new Song("Monster", "The secret side of me, I never let you see...");
Songs songs = new Songs(song1, song2, song3);

Singer christina = new Singer("Christina Aguilera");
Singer gaga = new Singer("Lady Gaga");
Singer madonna = new Singer("Madonna");
Singer britney = new Singer("Britney Spears");
Singer shakira = new Singer("Shakira");
Singer adele = new Singer("Adele");
Singer avril = new Singer("Avril Lavigne");
Singer nicki = new Singer("Nicki Minaj");
Singer kesha = new Singer("Ke$ha");
Singer kelly = new Singer("Kelly Clarkson");
Singer katy = new Singer("Katy Perry");
Singer rihanna = new Singer("Rihanna");
Singer beyonce = new Singer("Beyoncé");
Singer justin1 = new Singer("Justin Bieber");

Singer adam = new Singer("Adam Levine");
Guitarist james = new Guitarist("James Valentine");
Drummer matt = new Drummer("Matt Flynn");
Guitarist sam = new Guitarist("Sam Farrar");
Band maroonFive = new Band("Maroon 5", adam, james, matt, sam);

List<Competitor> competitors = new List<Competitor> { christina, gaga, madonna, britney, shakira, adele, avril, nicki, kesha, kelly, katy, rihanna, beyonce, justin1, maroonFive };

int numOfJudges = 5;
Competition comp = new AudienceCompetition(competitors, songs, numOfJudges);

/*
Judge simon = new Judge("Simon Cowell",
    "You didn't beat the compotition you crushed the compotition!",
    "You sounded like Dolly parton on helium. I only chose you because the other one was even worse.",
    "Don’t sing again. Both of you were terrible.");
Competition comp = new JudgeCompetition(competitors, songs, simon);
*/
comp.runCompetition();
Console.ReadLine();
