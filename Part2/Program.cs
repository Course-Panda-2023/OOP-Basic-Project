// See https://aka.ms/new-console-template for more information
using OOPFinal;
using OOPFinal.MusicPeople;
using OOPFinal.Songs;


Song christinaSong1 = new Song("Hurt", "Seems like it was yesterday when I saw your face...");
Singer christina = new Singer("Christina Aguilera", christinaSong1);

Song gagaSong1 = new Song("Bloody Mary", "Love is just a history that they may prove...");
Singer gaga = new Singer("Lady Gaga", gagaSong1);

Song madonaSong1 = new Song("Material Girl", "Some boys kiss me...");
Singer madonna = new Singer("Madonna", madonaSong1);

Song britneySong1 = new Song("Oops!…I Did It Again", "I think I did it again...");
Singer britney = new Singer("Britney Spears", britneySong1);

Song shakiraSong1 = new Song("Whenever, Wherever", "Lucky you were born that far away so...");
Singer shakira = new Singer("Shakira", shakiraSong1);

Song adeleSong1 = new Song("Rolling in the Deep", "There's a fire starting in my heart...");
Singer adele = new Singer("Adele", adeleSong1);

Song avrilSong1 = new Song("Sk8er Boi", "He was a boy...");
Singer avril = new Singer("Avril Lavigne", avrilSong1);

Song nickiSong1 = new Song("Anaconda", "My anaconda don't, my anaconda don't...");
Singer nicki = new Singer("Nicki Minaj", nickiSong1);

Song keshaSong1 = new Song("Cannibal", "I have a heart, I swear I do...");
Singer kesha = new Singer("Ke$ha", keshaSong1);

Song kellySong1 = new Song("Because Of You", "I will not make the same mistakes that you did...");
Singer kelly = new Singer("Kelly Clarkson", kellySong1);

Song katySong1 = new Song("E.T.", "You're so hypnotizing...");
Singer katy = new Singer("Katy Perry", katySong1);

Song rihannaSong1 = new Song("Diamonds", "Shine bright like a diamond...");
Singer rihanna = new Singer("Rihanna", rihannaSong1);

Song beyonceSong1 = new Song("Halo", "Remember those walls I built?...");
Singer beyonce = new Singer("Beyoncé", britneySong1);

Song justinSong1 = new Song("Ghost", "Youngblood thinks there's always tomorrow...");
Singer justin = new Singer("Justin Bieber", justinSong1);

List<Singer> competitors = new List<Singer> { christina, gaga, madonna, britney, shakira, adele, avril, nicki, kesha, kelly, katy, rihanna, beyonce, justin };


Judge simon = new Judge("Simon Cowell",
    "You didn't beat the compotition you crushed the compotition!",
    "You sounded like Dolly parton on helium. I only chose you because the other one was even worse.",
    "Don’t sing again. Both of you were terrible.");


Console.WriteLine("Welcome to our singing competition!!\n");

Random rnd = new Random();

int singerId1;
Singer singer1;
Song song1;
int singerId2;
Singer singer2;
Song song2;

int winnerId;
Singer winner = competitors[0];

int round = 1;
while (competitors.Count() > 1)
{
    Console.WriteLine($"Round {round}:");

    singerId1 = rnd.Next(competitors.Count());
    singer1 = competitors[singerId1];
    song1 = singer1.GetSong();

    do
    {
        singerId2 = rnd.Next(competitors.Count());
    }
    while (singerId2 == singerId1);
    singer2 = competitors[singerId2];
    song2 = singer2.GetSong();

    Console.WriteLine($"The first singer {singer1.Name} will sing \"{song1.Name}\".\n" +
        $"\"{song1.FirstLine}\"\n\n" +
        $"The second singer {singer2.Name} will sing \"{song2.Name}\".\n" +
        $"\"{song2.FirstLine}\"\n");

    winnerId = rnd.Next(2);
    if (winnerId == 0)
    {
        winner = singer1;
        competitors.RemoveAt(singerId2);
    }
    else
    {
        winner = singer2;
        competitors.RemoveAt(singerId1);
    }
    Console.WriteLine($"The winner that {simon.Name} chose is.. {winner.Name}!\n" +
    $"Lets hear what simon has to say about the winner's performance:\n" +
    $"\"{simon.GetUniqueResponse()}\"\n");

    round++;
}

Console.WriteLine($"The competition is over:\n" +
    $"The finale winner is {winner.Name}!!");

Console.ReadLine();
