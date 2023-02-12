// See https://aka.ms/new-console-template for more information

/*
 * TODO: Copy all of your code from part2 and continue here.
 */
using OOPFinal;

Song song1 = new Song("More");
Song song2 = new Song("Billionaire");
Song song3 = new Song("Lose Yourself");

List<Song> songsList = new List<Song>();
songsList.Add(song1);
songsList.Add(song2);
songsList.Add(song3);

Random rnd = new Random();

Singer madonna = new Singer("Madonna", songsList);
Singer britney = new Singer("Britney", songsList);
Singer shakira = new Singer("shakira", songsList);
Singer avril = new Singer("Avril", songsList);
Singer nicki = new Singer("Nicki", songsList);
Singer kesha = new Singer("Kesha", songsList);
Singer kelly = new Singer("Kelly", songsList);
Singer katy = new Singer("Katy", songsList);
Singer rihanna = new Singer("Rihanna", songsList);
Singer beyonce = new Singer("Beyonce", songsList);
Singer justin = new Singer("Justin", songsList);

List<Singer> singersList = new List<Singer>()
{
    madonna, britney, shakira, avril, nicki, kesha, kelly, rihanna, beyonce, justin
};


int croud = Convert.ToInt32(Console.ReadLine());

Dictionary<Singer, int> numOfChoises = new Dictionary<Singer, int>();
foreach (Singer singer in singersList)
{
    numOfChoises.Add(singer, 0);
}
for (int i = 0; i < croud; i++)
{
    int choose = rnd.Next(0, singersList.Count);
    Singer s = numOfChoises.ElementAt(choose).Key;
    numOfChoises[s]++;
}

Singer keyOfMaxValue = numOfChoises.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
Console.WriteLine("The winner of the competition is: " + keyOfMaxValue.Name);

Console.ReadLine();