// See https://aka.ms/new-console-template for more information

/*
 * TODO: Copy all of your code from part2 and continue here.
 */
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
Singer mami = new Singer("Justin", songsList);
Singer dadi = new Singer("Justin", songsList);
Singer papi = new Singer("Justin", songsList);
Singer sasi = new Singer("Justin", songsList);
Singer tati = new Singer("Justin", songsList);
Singer fafi = new Singer("Justin", songsList);
Singer jaji = new Singer("Justin", songsList);
Singer nani = new Singer("Justin", songsList);
Singer hahi = new Singer("Justin", songsList);
Singer rari = new Singer("Justin", songsList);
Singer juna1 = new Singer("Justin", songsList);
Singer juna2 = new Singer("Justin", songsList);
Singer popo = new Singer("Justin", songsList);
Singer koko = new Singer("Justin", songsList);

List<Singer> band1List = new List<Singer>() { mami, dadi };
List<Singer> band2List = new List<Singer>() { papi, sasi };
List<Singer> band3List = new List<Singer>() { tati, fafi };
List<Singer> band4List = new List<Singer>() { jaji, nani };
List<Singer> band5List = new List<Singer>() { hahi, rari };
List<Singer> band6List = new List<Singer>() { juna1, juna2 };
List<Singer> band7List = new List<Singer>() { popo, koko };

Band backstreetBoys = new Band("Backstreet boys", band1List, songsList);
Band westLife = new Band("Westlife", band2List, songsList);
Band sync = new Band("N’Sync", band3List, songsList);
Band high5 = new Band("High Five", band4List, songsList);
Band simplePlan = new Band("Simple Plan", band5List, songsList);
Band jonasBro = new Band("Jonas Brothers", band6List, songsList);
Band jackson5 = new Band("The Jackson 5", band6List, songsList);

List<Participant> participantsList = new List<Participant>()
{
    madonna, britney, shakira, avril, nicki, kesha, kelly, rihanna, beyonce, justin, backstreetBoys, westLife, sync, high5, simplePlan, jackson5, jonasBro
};


int croud = Convert.ToInt32(Console.ReadLine());

Dictionary<Participant, int> numOfChoises = new Dictionary<Participant, int>();
foreach (Participant participant in participantsList)
{
    numOfChoises.Add(participant, 0);
}
for (int i = 0; i < croud; i++)
{
    int choose = rnd.Next(0, participantsList.Count);
    Participant p = numOfChoises.ElementAt(choose).Key;
    numOfChoises[p]++;
}

Participant keyOfMaxValue = numOfChoises.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
Console.WriteLine("The winner of the competition is: " + keyOfMaxValue.GetName());
