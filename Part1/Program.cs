
// See https://aka.ms/new-console-template for more information
using OOPFinal;

List<Song> christinaList = new List<Song>();
List<Song> gagaList = new List<Song>();
Jugde simon = new Jugde("Simon Cowell");

Song christinasSong = new Song("Beautiful");
Song christinasSong1 = new Song("Genie in a Bottle");
Song christinasSong2 = new Song("Hurt");
Song christinasSong3 = new Song("Dirrty");

Song gagaSong = new Song("Shallow");
Song gagaSong1 = new Song("Bloody Mary");
Song gagaSong2 = new Song("Bad Romance");
Song gagaSong3 = new Song("Poker Face");

christinaList.Add(christinasSong);
christinaList.Add(christinasSong1);
christinaList.Add(christinasSong2);
christinaList.Add(christinasSong3);

gagaList.Add(gagaSong);
gagaList.Add(gagaSong1);
gagaList.Add(gagaSong2);
gagaList.Add(gagaSong3);

Singer christina = new Singer("Christina Aguilera", christinaList);
Singer gaga = new Singer("Lady Gaga", gagaList);

Console.WriteLine("Welcome to the singing COMPETITION! \nThe first singer to sing is Christina.");

Random rnd = new Random();
int cRandomSongIndex = rnd.Next(0, christinaList.Count);
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

Console.ReadLine();