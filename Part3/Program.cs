Random rnd = new Random();
Song song1 = new Song("Song 1");
Song song2 = new Song("Song 2");
Song song3 = new Song("Song 3");
Console.WriteLine("Songs Created");
List<Song> list = new List<Song>() { song1, song2, song3 };
Singer ladyGaga = new Singer("Lady Gaga", list);
Singer christinaAguilera = new Singer("Christina Aguilera", list);
Singer kesha = new Singer("Kesha", list);
Singer madona = new Singer("Madona", list);
Singer brittneySpears = new Singer("Brittney Spears", list);
Singer shakira = new Singer("Shakira", list);
Singer adele = new Singer("Adele", list);
Singer rihanna = new Singer("Rihanna", list);
List<Singer> singers = new List<Singer>() { ladyGaga, christinaAguilera, kesha, madona, brittneySpears, shakira, adele, rihanna };
Console.WriteLine("Singers Created");
ContestDecidedByCrowd contest = new ContestDecidedByCrowd(singers);
Console.WriteLine("Contest Created");
while (contest.SingersList.Count > 1)
{
    Singer loser = contest.SimulateRound();
    contest.SingersList.Remove(loser);
    Console.WriteLine(loser.Name + " Lost!");
}
Console.WriteLine(contest.SingersList[0].Name + " Is The Winner!");