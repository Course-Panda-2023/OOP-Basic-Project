using Part1;
using Part2;

Judge simon = new Judge(1234512, "Simon Kawel", 1.83, 35, true);
Contestent madona = new Contestent(1322332, "Madona", 1.58, false, true);
Contestent britney = new Contestent(1323362, "Britney Spirs", 1.48, false, true);
Contestent shakira = new Contestent(1321332, "Shakira", 1.78, false, true);
Contestent adele = new Contestent(13232332, "Adele", 1.58, false, true);
Contestent abril = new Contestent(13224332, "Abrile Lavin", 1.64, false, true);
Contestent nikki = new Contestent(1323532, "Nikki Minaj", 1.62, false, true);
Contestent kesha = new Contestent(132365432, "Ke$ha", 1.61, false, true);
Contestent kelly = new Contestent(13982332, "Kelly Klarckson", 1.63, false, true);
Contestent kaity = new Contestent(12132332, "Kaity Perry", 1.58, false, true);
Contestent rihana = new Contestent(53132332, "Rihana", 1.60, false, true);
Contestent beyonce = new Contestent(132333522, "Beyonce", 1.70, false, true);
Contestent justin = new Contestent(132331252, "Justin Biber", 1.72, false, true);

Song song1 = new Song("The Best Day Ever", "Mr. Sun came up and he smiled at me\r\nSaid it's gonna be a good one just wait and see\r\nJumped outta bed, and I ran outside\r\nFeeling so extra ecstatified\r\nIt's the best day ever (best day ever)\r\nIt's the best day ever (best day ever)");
Song song2 = new Song("Mundial WakaWaka", "Tsamina mina, eh, eh\r\nWaka waka, eh, eh\r\nTsamina mina zangalewa, anawa-a-a\r\n");
Song song3 = new Song("Finias and Ferb", "Finding a dodo bird\r\nPainting a continent\r\nOr driving our sister insane\r\nAs you can see\r\nThere's a whole lot of stuff to do\r\nBefore school starts this fall\r\nPhineas: Come on Perry!\r\nSo stick with us\r\n'Cause Phineas and Ferb are gonna do it all!\r\nSo stick with us\r\n'Cause Phineas and Ferb are gonna do it all!");

List<Contestent> contestentsList = ContestManager.ConvertToContestentList(madona, britney, shakira, adele, abril, nikki, kesha, kelly, 
    kaity, rihana, beyonce, justin);

Contestent winner = ContestManager.RunContestWithAudience(contestentsList, 5000, song1, song2, song3);

Console.WriteLine($"ladies, gentelman and basketballs, the winner, with {winner.Votes} votes, of the voice is {winner.Name}!!!");
Console.WriteLine();

foreach (Contestent contestent in contestentsList)
{
    Console.WriteLine($"{contestent.Name}, finished with {contestent.Votes} votes!");
}