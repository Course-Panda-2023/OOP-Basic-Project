// See https://aka.ms/new-console-template for more information
using OOPFinal;
using OOPFinal.MusicPeople;
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

Singer nick1 = new Singer("Nick Carter");
Singer kevin1 = new Singer("Kevin Richardson");
Singer aj = new Singer("AJ McLean");
Singer brian1 = new Singer("Brian Littrell");
Singer howie = new Singer("Howie Dorough");
Band backstreetBoys = new Band("Backstreet Boys", nick1, kevin1, aj, brian1, howie);

Singer mark = new Singer("Mark Feehily");
Singer brian2 = new Singer("Brian McFadden");
Singer shane = new Singer("Shane Filan");
Singer nicky = new Singer("Nicky Byrne");
Singer kian = new Singer("Kian Egan");
Band westlife = new Band("Westlife", mark, brian2, shane, nicky, kian);

Singer justin2 = new Singer("Justin Timberlake");
Singer jc = new Singer("JC Chasez");
Singer lance = new Singer("Lance Bass");
Singer joey = new Singer("Joey Fatone");
Singer chris = new Singer("Chris Kirkpatrick");
Band nsync = new Band("NSYNC", justin2, jc, lance, joey, chris);

Singer russell = new Singer("Russell Neal");
Singer marcus = new Singer("Marcus Sanders");
Singer treston = new Singer("Treston Irby");
Singer shannon = new Singer("Shannon Gill");
Singer terrell = new Singer("Terrell Carr");
Singer dre = new Singer("Dre Ramseur");
Singer tony = new Singer("Tony Thompson");
Band hiFive = new Band("Hi-Five", russell, marcus, treston, shannon, terrell, dre, tony);

Singer pierre = new Singer("Pierre Bouvier");
Singer david = new Singer("David Desrosiers");
Singer jeff = new Singer("Jeff Stinco");
Singer chuck = new Singer("Chuck Comeau");
Singer sebastien = new Singer("Sébastien Lefebvre");
Band simplePlan = new Band("Simple Plan", pierre, david, jeff, chuck, sebastien);

Singer nick2 = new Singer("Nick Jonas");
Singer joe = new Singer("Joe Jonas");
Singer kevin2 = new Singer("Kevin Jonas");
Band jonasBrothers = new Band("Jonas Brothers", nick2, joe, kevin2);

Singer michael = new Singer("Michael Jackson");
Singer randy = new Singer("Randy Jackson");
Singer jermaine = new Singer("Jermaine Jackson");
Singer tito = new Singer("Tito Jackson");
Singer marlon = new Singer("Marlon Jackson");
Singer jackie = new Singer("Jackie Jackson");
Band theJackson5 = new Band("The Jackson 5", michael, randy, jermaine, tito, marlon, jackie);

List<Competitor> competitors = new List<Competitor> { christina, gaga, madonna, britney, shakira, adele, avril, nicki, kesha, kelly, katy, rihanna, beyonce, justin1, backstreetBoys, westlife, nsync, hiFive, simplePlan, jonasBrothers, theJackson5 };

int numOfJudges = 5;

Console.WriteLine("Welcome to our singing competition!!\n");
Song curSong;
for (int i = 0; i < competitors.Count(); i++)
{
    curSong = songs.GetSong();
    Console.WriteLine($"Our {i + 1} competitor is {competitors[i].Name} and will sing \"{curSong.Name}\".\n" +
        $"\"{curSong.FirstLine}\"\n\n");
}

int[] votes = new int[competitors.Count];
for (int i = 0; i < competitors.Count; i++)
    votes[i] = 0;
int curVote;
for (int i = 1; i <= numOfJudges; i++)
{
    Console.WriteLine($"Judge {i} who would you like to vote for? (Enter the number of performance)");
    try
    {
        votes[Convert.ToInt32(Console.ReadLine()) - 1]++;

    }
    catch (Exception) { Console.WriteLine("You've entered invalid value, vote will be ignored."); }
}

int maxVotes = votes.Max();
List<string> winners = new List<string>();
for (int i = 0; i < votes.Length; i++)
{
    if (votes[i] == maxVotes)
        winners.Add(competitors[i].Name);
}

if (winners.Count > 1)
    Console.WriteLine($"The competition is over:\n" +
        $"The finale winners are {string.Join(", ", winners)}!!");
else
    Console.WriteLine($"The competition is over:\n" +
        $"The finale winner is {string.Join(", ", winners)}!!");

Console.ReadLine();