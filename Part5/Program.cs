// See https://aka.ms/new-console-template for more information

/*
 * TODO: Copy all of your code from part4 and continue here.
 */
using OOPFinal;
// See https://aka.ms/new-console-template for more information

/*
 * TODO: Copy all of your code from part3 and continue here.
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
Singer m51 = new Singer("Justin", songsList);
Singer m52 = new Singer("Justin", songsList);
Singer blink1 = new Singer("Justin", songsList);
Singer blink2 = new Singer("Justin", songsList);
Singer green1 = new Singer("Justin", songsList);
Singer green2 = new Singer("Justin", songsList);
Singer second1 = new Singer("Justin", songsList);
Singer second2 = new Singer("Justin", songsList);
Singer nickel1 = new Singer("Justin", songsList);
Singer nickel2 = new Singer("Justin", songsList);
Singer sum1 = new Singer("Justin", songsList);
Singer sum2 = new Singer("Justin", songsList);
Singer lmfao1 = new Singer("Justin", songsList);
Singer lmfao2 = new Singer("Justin", songsList);

Drummer drum1 = new Drummer("d1");
Drummer drum2 = new Drummer("d1");
Drummer drum3 = new Drummer("d1");
Drummer drum4 = new Drummer("d1");
Drummer drum5 = new Drummer("d1");
Drummer drum6 = new Drummer("d1");
Drummer drum7 = new Drummer("d1");
Drummer drumM5 = new Drummer("d1");
Drummer drumB182 = new Drummer("d1");
Drummer drumGreen = new Drummer("d1");
Drummer drum30Seconds = new Drummer("d1");
Drummer drumNickel = new Drummer("d1");
Drummer drumSum41 = new Drummer("d1");
Drummer drumLMFAO = new Drummer("d1");

Guitarist guitarist1 = new Guitarist("g1");
Guitarist guitarist2 = new Guitarist("g1");
Guitarist guitarist3 = new Guitarist("g1");
Guitarist guitarist4 = new Guitarist("g1");
Guitarist guitarist5 = new Guitarist("g1");
Guitarist guitarist6 = new Guitarist("g1");
Guitarist guitarist7 = new Guitarist("g1");
Guitarist guitaristM5 = new Guitarist("g1");
Guitarist guitaristB182 = new Guitarist("g1");
Guitarist guitaristGreen = new Guitarist("g1");
Guitarist guitarist30Seconds = new Guitarist("g1");
Guitarist guitaristNickel = new Guitarist("g1");
Guitarist guitaristSum41 = new Guitarist("g1");
Guitarist guitaristLMFAO = new Guitarist("g1");

List<Singer> band1List = new List<Singer>() { mami, dadi };
List<Singer> band2List = new List<Singer>() { papi, sasi };
List<Singer> band3List = new List<Singer>() { tati, fafi };
List<Singer> band4List = new List<Singer>() { jaji, nani };
List<Singer> band5List = new List<Singer>() { hahi, rari };
List<Singer> band6List = new List<Singer>() { juna1, juna2 };
List<Singer> band7List = new List<Singer>() { popo, koko };
List<Singer> M5List = new List<Singer>() { m52, m51 };
List<Singer> B182List = new List<Singer>() { blink1, blink2 };
List<Singer> GreenList = new List<Singer>() { green1, green2 };
List<Singer> secondsList = new List<Singer>() { second1, second2 };
List<Singer> nickelList = new List<Singer>() { nickel1, nickel2 };
List<Singer> sumlList = new List<Singer>() { sum1, sum2 };
List<Singer> lmfaoList = new List<Singer>() { lmfao1, lmfao2 };

Band backstreetBoys = new Band("Backstreet boys", band1List, drum1, guitarist1, songsList);
Band westLife = new Band("Westlife", band2List, drum2, guitarist2, songsList);
Band sync = new Band("N’Sync", band3List, drum3, guitarist3, songsList);
Band high5 = new Band("High Five", band4List, drum4, guitarist4, songsList);
Band simplePlan = new Band("Simple Plan", band5List, drum5, guitarist5, songsList);
Band jonasBro = new Band("Jonas Brothers", band6List, drum6, guitarist6, songsList);
Band jackson5 = new Band("The Jackson 5", band7List, drum7, guitarist7, songsList);
Band maroon5 = new Band("Maroon 5", M5List, drumM5, guitaristM5, songsList);
Band b182 = new Band("Blink 182", B182List, drumB182, guitaristB182, songsList);
Band green = new Band("Green Day", GreenList, drumGreen, guitaristGreen, songsList);
Band second = new Band("30 Seconds to Mars", secondsList, drum30Seconds, guitarist30Seconds, songsList);
Band nickel = new Band("Nickelback", nickelList, drumNickel, guitaristNickel, songsList);
Band sum = new Band("Sum41", sumlList, drumSum41, guitaristSum41, songsList);
Band lmfao = new Band("LMFAO", lmfaoList, drumLMFAO, guitaristLMFAO, songsList);

List<Participant> participantsList = new List<Participant>()
{
    madonna, britney, shakira, avril, nicki, kesha, kelly, rihanna, beyonce, justin, backstreetBoys, westLife, sync, high5,
    simplePlan, jackson5, jonasBro, maroon5, b182, green, second, nickel, sum, lmfao
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
Console.ReadLine();
