using Part5;

Judge simon = new Judge(1234512, "Simon Kawel", 1.83, 35, true);
Singer madona = new Singer(1322332, "Madona", 1.58, false, true);
Singer britney = new Singer(1323362, "Britney Spirs", 1.48, false, true);
Singer shakira = new Singer(1321332, "Shakira", 1.78, false, true);
Singer adele = new Singer(13232332, "Adele", 1.58, false, true);
Singer abril = new Singer(13224332, "Abrile Lavin", 1.64, false, true);
Singer nikki = new Singer(1323532, "Nikki Minaj", 1.62, false, true);
Singer kesha = new Singer(132365432, "Ke$ha", 1.61, false, true);
Singer kelly = new Singer(13982332, "Kelly Klarckson", 1.63, false, true);
Singer kaity = new Singer(12132332, "Kaity Perry", 1.58, false, true);
Singer rihana = new Singer(53132332, "Rihana", 1.60, false, true);
Singer beyonce = new Singer(132333522, "Beyonce", 1.70, false, true);
Singer justin = new Singer(132331252, "Justin Biber", 1.72, false, true);

Drummer bilHaDebil = new Drummer(123123, "BIl the Debil", 1.83, "Tof", "Wood");
Guitarist motiLochim = new Guitarist(1234132123, "Motti Lochim", 1.81, "Bass", "Plastic");


Band maroon = new Band("Maroon 5", true, true, new List<Singer>() { (Singer)justin, (Singer)rihana },
        new List<Guitarist>() { motiLochim }, new List<Drummer>() { bilHaDebil });
Band blink = new Band("Blink 182", true, true, new List<Singer>() { (Singer)justin, (Singer)nikki },
        new List<Guitarist>() { motiLochim }, new List<Drummer>() { bilHaDebil });
Band greenDay = new Band("Green Day", true, true, new List<Singer>() { (Singer)justin, (Singer)kelly },
        new List<Guitarist>() { motiLochim }, new List<Drummer>() { bilHaDebil });
Band mars = new Band("30 Second to Mars", true, true, new List<Singer>() { (Singer)justin, (Singer)kesha },
        new List<Guitarist>() { motiLochim }, new List<Drummer>() { bilHaDebil });
Band nickelback = new Band("Nickelback", true, true, new List<Singer>() { (Singer)justin, (Singer)abril },
        new List<Guitarist>() { motiLochim }, new List<Drummer>() { bilHaDebil });
Band sumFour = new Band("Sum41", true, true, new List<Singer>() { (Singer)justin, (Singer)madona },
        new List<Guitarist>() { motiLochim }, new List<Drummer>() { bilHaDebil });
Band lmfao = new Band("lauging my **** ass off", true, true, new List<Singer>() { (Singer)justin, (Singer)adele },
        new List<Guitarist>() { motiLochim }, new List<Drummer>() { bilHaDebil });

List<Contestent> contestentsList = new List<Contestent>(){madona, britney, shakira, adele, abril, nikki, kesha, kelly,
    kaity, rihana, beyonce, justin};
List<Band> bandList = new List<Band>() { maroon, blink, greenDay, mars, nickelback, sumFour, lmfao};
List<Band> dupbandList = new List<Band>() { maroon, blink, greenDay, mars, nickelback, sumFour, lmfao};

foreach (Band band in dupbandList)
{
    if (!band.IsValidLists())
    {
        bandList.Remove(band);
        Console.WriteLine($"{band.GetName()} is missing singers/drummers/guitaists and can't take part in the show.");
    }
    else
    {
        contestentsList.Add(band);
    }
    Console.WriteLine();
}

Song song1 = new Song("The Best Day Ever", "Mr. Sun came up and he smiled at me\r\nSaid it's gonna be a good one just wait and see\r\nJumped outta bed, and I ran outside\r\nFeeling so extra ecstatified\r\nIt's the best day ever (best day ever)\r\nIt's the best day ever (best day ever)");
Song song2 = new Song("Mundial WakaWaka", "Tsamina mina, eh, eh\r\nWaka waka, eh, eh\r\nTsamina mina zangalewa, anawa-a-a\r\n");
Song song3 = new Song("Finias and Ferb", "Finding a dodo bird\r\nPainting a continent\r\nOr driving our sister insane\r\nAs you can see\r\nThere's a whole lot of stuff to do\r\nBefore school starts this fall\r\nPhineas: Come on Perry!\r\nSo stick with us\r\n'Cause Phineas and Ferb are gonna do it all!\r\nSo stick with us\r\n'Cause Phineas and Ferb are gonna do it all!");



Contestent winner = ContestManager.RunContestWithAudience(contestentsList, 5000, song1, song2, song3);

Console.WriteLine($"ladies, gentelman and basketballs, the winner, with {winner.Votes} votes, of the voice is {winner.GetName()}!!!");
Console.WriteLine();

foreach (Contestent contestent in contestentsList)
{
    Console.WriteLine($"{contestent.GetName()}, finished with {contestent.Votes} votes!");
}

Console.WriteLine();
Console.WriteLine("round 2!!!");
Console.WriteLine();

ContestManager.RunContestWithJudge(contestentsList, simon, song1, song2, song3);