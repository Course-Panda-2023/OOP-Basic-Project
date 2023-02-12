List<Song> christinaList = new List<Song>();
List<Song> gagaList = new List<Song>();
Jugde simon = new Jugde("Simon Cowell");

Song christinasSong = new Song("Beautiful");
//Song christinasSong1 = new Song("Genie in a Bottle");
//Song christinasSong2 = new Song("Hurt");
//Song christinasSong3 = new Song("Dirrty");

Song gagaSong = new Song("Shallow");
//Song gagaSong1 = new Song("Bloody Mary");
//Song gagaSong2 = new Song("Bad Romance");
//Song gagaSong3 = new Song("Poker Face");

christinaList.Add(christinasSong);
//christinaList.Add(christinasSong1);
//christinaList.Add(christinasSong2);
//christinaList.Add(christinasSong3);

gagaList.Add(gagaSong);
//gagaList.Add(gagaSong1);
//gagaList.Add(gagaSong2);
//gagaList.Add(gagaSong3);

Singer christina = new Singer("Christina Aguilera", christinaList);
Singer gaga = new Singer("Lady Gaga", gagaList);

/*
Console.WriteLine("Welcome to the singing COMPETITION! \nThe first singer to sing is Christina.");

Random rnd = new Random();
int cRandomSongIndex = rnd.Next(0,christinaList.Count);
Console.WriteLine("She sings: " + christinaList[cRandomSongIndex].Name);

Console.WriteLine("The next singer to sing is Lady Gaga.");
int lRandomSongIndex = rnd.Next(0, gagaList.Count);
Console.WriteLine("she sings: " + gagaList[lRandomSongIndex].Name);

Console.WriteLine("The winner that Simon chose is:");

int winnerIndex = rnd.Next(0, 2);
if (winnerIndex == 0)
    Console.WriteLine("Christina");
else
    Console.WriteLine("Lady Gaga");
*/

List<Song> madonnaList = new List<Song>();
List<Song> britneyList = new List<Song>();
List<Song> shakiraList = new List<Song>();
List<Song> adeleList = new List<Song>();
List<Song> avrilList = new List<Song>();
List<Song> nickiList = new List<Song>();
List<Song> keshaList = new List<Song>();
List<Song> kellyList = new List<Song>();
List<Song> katyList = new List<Song>();
List<Song> rihannaList = new List<Song>();
List<Song> beyonceList = new List<Song>();
List<Song> justinList = new List<Song>();

Song madonnaSong = new Song("Hung Up");
Song britneySong = new Song("Toxic");
Song shakiraSong = new Song("Waka Waka");
Song avrilSong = new Song("Complicated");
Song nickiSong = new Song("Super Bass");
Song keshaSong = new Song("Take It Off");
Song kellySong = new Song("Because Of You");
Song katySong = new Song("Roar");
Song rihannaSong = new Song("Umbrella");
Song beyonceSong = new Song("Break My Soul");
Song justinSong = new Song("Baby");

madonnaList.Add(madonnaSong);
britneyList.Add(britneySong);
shakiraList.Add(shakiraSong);
avrilList.Add(avrilSong);
nickiList.Add(nickiSong);
keshaList.Add(keshaSong);
kellyList.Add(kellySong);
katyList.Add(katySong);
rihannaList.Add(rihannaSong);
beyonceList.Add(beyonceSong);
justinList.Add(justinSong);

Singer madonna = new Singer("Madonna", madonnaList);
Singer britney = new Singer("Britney", britneyList);
Singer shakira = new Singer("shakira", shakiraList);
Singer avril = new Singer("Avril", avrilList);
Singer nicki = new Singer("Nicki", nickiList);
Singer kesha = new Singer("Kesha", keshaList);
Singer kelly = new Singer("Kelly", kellyList);
Singer katy = new Singer("Katy", katyList);
Singer rihanna = new Singer("Rihanna", rihannaList);
Singer beyonce = new Singer("Beyonce", beyonceList);
Singer justin = new Singer("Justin", justinList);


List<Singer> singerList = new List<Singer>();
singerList.Add(madonna);
singerList.Add(britney);
singerList.Add(shakira);
singerList.Add(avril);
singerList.Add(nicki);
singerList.Add(kesha);
singerList.Add(kelly);
singerList.Add(katy);
singerList.Add(rihanna);
singerList.Add(beyonce);
singerList.Add(justin);
singerList.Add(gaga);
singerList.Add(christina);

Console.WriteLine("Welcome to the singing COMPETITION!");
Random rnd = new Random();
while (singerList.Count > 1)
{
    int first = rnd.Next(0, singerList.Count);
    int second = rnd.Next(0, singerList.Count);
    while (first == second)
        second = rnd.Next(0, singerList.Count);
    int winner = rnd.Next(0, 2);
    if (winner == 0)
        singerList.RemoveAt(second);
    else
        singerList.RemoveAt(first);
}
Console.WriteLine(singerList[0].GetName() + " is the winner of the competition");
Console.ReadLine();