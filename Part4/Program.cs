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

Singer bandSinger1 = new Singer("BandSinger", list);
Singer bandSinger2 = new Singer("BandSinger2", list);
Singer bandSinger3 = new Singer("BandSinger3", list);
List<Singer> bandList = new List<Singer>() { bandSinger1, bandSinger2, bandSinger3 };
Band band = new Band("Best Band", bandList, list);
List<ContestParticipant> participants = new List<ContestParticipant>() { ladyGaga, christinaAguilera, kesha, madona, brittneySpears, shakira, adele, rihanna, band };
Console.WriteLine("Singers Created");
ContestWithBands contest = new ContestWithBands(participants);
Console.WriteLine("Contest Created");
while (contest.ParticipantsList.Count > 1)
{
    ContestParticipant loser = contest.SimulateRound();
    contest.ParticipantsList.Remove(loser);
    Console.WriteLine(loser.Name + " Lost!");
}
Console.WriteLine(contest.ParticipantsList[0].Name + " Is The Winner!");