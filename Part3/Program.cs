// See https://aka.ms/new-console-template for more information
using OOPFinal;
using OOPFinal.MusicPeople;
using OOPFinal.Songs;

Song song1 = new Song("The Fox (What Does the Fox Say?)", "Dog goes \"woof\"...");
Song song2 = new Song("Thriller", "It's close to midnight...");
Song song3 = new Song("Monster", "The secret side of me, I never let you see...");

Singer christina = new Singer("Christina Aguilera", song1, song2, song3);
Singer gaga = new Singer("Lady Gaga", song1, song2, song3);
Singer madonna = new Singer("Madonna", song1, song2, song3);
Singer britney = new Singer("Britney Spears", song1, song2, song3);
Singer shakira = new Singer("Shakira", song1, song2, song3);
Singer adele = new Singer("Adele", song1, song2, song3);
Singer avril = new Singer("Avril Lavigne", song1, song2, song3);
Singer nicki = new Singer("Nicki Minaj", song1, song2, song3);
Singer kesha = new Singer("Ke$ha", song1, song2, song3);
Singer kelly = new Singer("Kelly Clarkson", song1, song2, song3);
Singer katy = new Singer("Katy Perry", song1, song2, song3);
Singer rihanna = new Singer("Rihanna", song1, song2, song3);
Singer beyonce = new Singer("Beyoncé", song1, song2, song3);
Singer justin = new Singer("Justin Bieber", song1, song2, song3);

List<Singer> competitors = new List<Singer> { christina, gaga, madonna, britney, shakira, adele, avril, nicki, kesha, kelly, katy, rihanna, beyonce, justin };

int numOfJudges = 5;

Console.WriteLine("Welcome to our singing competition!!\n");
Song curSong;
for (int i = 0; i < competitors.Count(); i++)
{
    curSong = competitors[i].GetSong();
    Console.WriteLine($"Our {i + 1} singer is {competitors[i].Name} and will sing \"{curSong.Name}\".\n" +
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

Console.WriteLine($"The competition is over:\n" +
    $"The finale winners are {string.Join(", ", winners)}!!");

Console.ReadLine();
