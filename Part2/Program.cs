Song universalSong1 = new Song("Universal 1");
Song universalSong2 = new Song("Universal 2");
List<Song> list = new List<Song>() { universalSong1, universalSong2 };
Judge judge = new Judge("Liav");
Singer ladyGaga = new Singer("Lady Gaga", list);
Singer christinaAguilera = new Singer("Christina Aguilera", list);
Singer kesha = new Singer("Kesha", list);
Singer madona = new Singer("Madona", list);
Singer brittneySpears = new Singer("Brittney Spears", list);
Singer shakira = new Singer("Shakira", list);
Singer adele = new Singer("Adele", list);
Singer rihanna = new Singer("Rihanna", list);
List<Singer> singers = new List<Singer>() { ladyGaga, christinaAguilera, kesha, madona, brittneySpears, shakira, adele, rihanna };
Random rnd = new Random();
while (singers.Count > 1)
{
    int firstIndex = rnd.Next(0, singers.Count);
    int secondIndex = rnd.Next(0, singers.Count);
    while (firstIndex == secondIndex)
        secondIndex = rnd.Next(0, singers.Count);
    Contest contest = new Contest(judge, singers[firstIndex], singers[secondIndex]);
    Singer eliminate = contest.SimulateRound();
    singers.Remove(eliminate);
}
Console.WriteLine(singers[0].Name + " Wins The Contest!");