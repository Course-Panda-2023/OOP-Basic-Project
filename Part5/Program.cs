// See https://aka.ms/new-console-template for more information



using System.Globalization;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using OOPBasicProject;

static void Part1()
{
   

    List<OOPBasicProject.Song> CompetitionSongList = new List<OOPBasicProject.Song>();
    CompetitionSongList.Add(new OOPBasicProject.Song("Song 1", "Author 1", "3:00", "2019"));
    CompetitionSongList.Add(new OOPBasicProject.Song("Song 2", "Author 2", "3:00", "2018"));

    List<OOPBasicProject.Competitor> singers = new List<OOPBasicProject.Competitor>();
    singers.Add(new OOPBasicProject.Singer("Ledy Gaga", 36, "New York", "USA"));
    singers.Add(new OOPBasicProject.Singer("Christina Aguilera", 42, "New York", "USA"));

    List<OOPBasicProject.Jury> juries = new List<OOPBasicProject.Jury>();
    juries.Add(new OOPBasicProject.Jury("Simon Cowell", 63, "London", "UK"));

    Helper.SelectingSongsByCompetitors(singers, CompetitionSongList);
    Competitor absoluteWinner = Helper.GetAbsoluteWinner(Helper.GetVotesFromJury(singers, juries));

    Console.WriteLine("The winner of the song competition is: " + absoluteWinner.Name);
    Console.ReadLine();
}

//Part1();

static void Part2()
{
    List<OOPBasicProject.Song> CompetitionSongList = new List<OOPBasicProject.Song>();
    CompetitionSongList.Add(new OOPBasicProject.Song("Song 1", "Author 1", "3:00", "2019"));
    CompetitionSongList.Add(new OOPBasicProject.Song("Song 2", "Author 2", "3:00", "2018"));


    List<OOPBasicProject.Competitor> singers = new List<OOPBasicProject.Competitor>();
    //singers.Add(new OOPBasicProject.Singer("Ledy Gaga", 36, "New York", "USA"));
    //singers.Add(new OOPBasicProject.Singer("Christina Aguilera", 42, "New York", "USA"));
    singers.Add(new OOPBasicProject.Singer("Madonna", 42, "New York", "USA"));
    singers.Add(new OOPBasicProject.Singer("Britney Spears", 42, "New York", "USA"));
    singers.Add(new OOPBasicProject.Singer("Shakira", 42, "New York", "USA"));
    singers.Add(new OOPBasicProject.Singer("Adele", 42, "New York", "USA"));
    singers.Add(new OOPBasicProject.Singer("Avril Lavigne", 42, "New York", "USA"));
    singers.Add(new OOPBasicProject.Singer("Nicki Minaj", 42, "New York", "USA"));
    singers.Add(new OOPBasicProject.Singer("Ke$ha", 42, "New York", "USA"));
    singers.Add(new OOPBasicProject.Singer("Kelly Clarkson", 42, "New York", "USA"));
    singers.Add(new OOPBasicProject.Singer("Katy Perry", 42, "New York", "USA"));
    singers.Add(new OOPBasicProject.Singer("Rhianna", 42, "New York", "USA"));
    singers.Add(new OOPBasicProject.Singer("Beyonce", 42, "New York", "USA"));
    singers.Add(new OOPBasicProject.Singer("Justin Bieber", 42, "New York", "USA"));



    List<OOPBasicProject.Jury> juries = new List<OOPBasicProject.Jury>();
    juries.Add(new OOPBasicProject.Jury("Simon Cowell", 63, "London", "UK"));

    
    Random rnd = new Random();
    
    
    List<int> singersIndexes = new List<int>();
    
    List<List<OOPBasicProject.Competitor>> pairsList = Helper.MakeRandomPairs(singers);
    List<Competitor> finalists = new List<Competitor>();
    foreach(var pair in pairsList)
    {
        Console.WriteLine("{0}, {1}", pair[0].ToString(), pair[1].ToString());
        finalists.Add(Helper.GetAbsoluteWinner(Helper.GetVotesFromJury(pair, juries)));
        //finalists.Add()
    }
    //Console.WriteLine("The winner of the song competition is: " + Helper.GetAbsoluteWinner(finalists).Name);
    Console.WriteLine();
    
    pairsList = Helper.MakeRandomPairs(finalists);
    finalists.Clear();  
    foreach (var pair in pairsList)
    {
        Console.WriteLine("{0}, {1}", pair[0].ToString(), pair[1].ToString());
        finalists.Add(Helper.GetAbsoluteWinner(Helper.GetVotesFromJury(pair, juries)));
        //finalists.Add()
    }
    Console.WriteLine();
    foreach (var finalist in finalists)
    {
        Console.WriteLine(finalist.Name);
    }
    Competitor absoluteWinner = Helper.GetAbsoluteWinner(Helper.GetVotesFromJury(finalists, juries));
    Console.WriteLine("The winner of the song competition is: " + absoluteWinner.Name);
    Console.ReadLine();
}
//Part2();



static void Part3()
{
    List<OOPBasicProject.Song> CompetitionSongList = new List<OOPBasicProject.Song>();
    CompetitionSongList.Add(new OOPBasicProject.Song("Song 1", "Author 1", "3:00", "2020"));
    CompetitionSongList.Add(new OOPBasicProject.Song("Song 2", "Author 2", "3:00", "2019"));
    CompetitionSongList.Add(new OOPBasicProject.Song("Song 3", "Author 3", "3:00", "2018"));

    List<Audience> audience = new List<Audience>();    
    audience = Helper.MakeRandomAudienceList();

    List<OOPBasicProject.Competitor> singers = new List<OOPBasicProject.Competitor>();
    singers.Add(new OOPBasicProject.Singer("Ledy Gaga", 36, "New York", "USA"));
    singers.Add(new OOPBasicProject.Singer("Christina Aguilera", 42, "New York", "USA"));
    singers.Add(new OOPBasicProject.Singer("Madonna", 42, "New York", "USA"));
    singers.Add(new OOPBasicProject.Singer("Britney Spears", 42, "New York", "USA"));
    singers.Add(new OOPBasicProject.Singer("Shakira", 42, "New York", "USA"));
    singers.Add(new OOPBasicProject.Singer("Adele", 42, "New York", "USA"));
    singers.Add(new OOPBasicProject.Singer("Avril Lavigne", 42, "New York", "USA"));
    singers.Add(new OOPBasicProject.Singer("Nicki Minaj", 42, "New York", "USA"));
    singers.Add(new OOPBasicProject.Singer("Ke$ha", 42, "New York", "USA"));
    singers.Add(new OOPBasicProject.Singer("Kelly Clarkson", 42, "New York", "USA"));
    singers.Add(new OOPBasicProject.Singer("Katy Perry", 42, "New York", "USA"));
    singers.Add(new OOPBasicProject.Singer("Rhianna", 42, "New York", "USA"));
    singers.Add(new OOPBasicProject.Singer("Beyonce", 42, "New York", "USA"));
    singers.Add(new OOPBasicProject.Singer("Justin Bieber", 42, "New York", "USA"));
    Helper.SelectingSongsByCompetitors(singers, CompetitionSongList);

    /*foreach (var a in audience)
    {
        //Console.WriteLine(a.ToString());
    }*/
    //Console.WriteLine(audience.Count);
    Competitor absoluteWinner = Helper.GetAbsoluteWinner(Helper.GetVotesFromAudience(singers, audience));

    Console.WriteLine("The winner of the song competition is: " + absoluteWinner.Name);
    Console.ReadLine();

}

//Part3();

static void Part4()
{
    List<OOPBasicProject.Song> CompetitionSongList = new List<OOPBasicProject.Song>();
    CompetitionSongList.Add(new OOPBasicProject.Song("Song 1", "Author 1", "3:00", "2020"));
    CompetitionSongList.Add(new OOPBasicProject.Song("Song 2", "Author 2", "3:00", "2019"));
    CompetitionSongList.Add(new OOPBasicProject.Song("Song 3", "Author 3", "3:00", "2018"));
    Random random = new Random();
   
    List<Competitor> competitionCompetitors = new List<Competitor>();
    competitionCompetitors.Add(new OOPBasicProject.Band("Backstreet boys"));
    competitionCompetitors.Add(new OOPBasicProject.Band("N’Sync"));
    competitionCompetitors.Add(new OOPBasicProject.Band("High Five"));
    competitionCompetitors.Add(new OOPBasicProject.Band("Simple Plan"));
    competitionCompetitors.Add(new OOPBasicProject.Band("Jonas Brothers"));
    competitionCompetitors.Add(new OOPBasicProject.Band("The Jackson 5"));  
    
    /*foreach (Band band in competitionCompetitors)
    {
        
        band.SelectSongByBandParticipants(CompetitionSongList);
    }*/
  
    int soloistRandNum = random.Next(1, 10);
    int stringRandLength = random.Next(3, 12);

    //Adding soloists to the competition randomly
    for (int i = 0; i < soloistRandNum; i++)
    {
        string randomName = Helper.RandomString(stringRandLength);
        competitionCompetitors.Add(new OOPBasicProject.Singer(randomName));
    }

    List<Audience> audience = new List<Audience>();
    audience = Helper.MakeRandomAudienceList();
    
    Competitor absoluteWinner = Helper.GetAbsoluteWinner(Helper.GetVotesFromAudience(competitionCompetitors, audience));
    Console.WriteLine("The winner of the song competition is: " + absoluteWinner.CompetitorName);
    Console.ReadLine();
}

//Part4();

static void Part5()
{
    List<OOPBasicProject.Song> CompetitionSongList = new List<OOPBasicProject.Song>();
    CompetitionSongList.Add(new OOPBasicProject.Song("Song 1", "Author 1", "3:00", "2020"));
    CompetitionSongList.Add(new OOPBasicProject.Song("Song 2", "Author 2", "3:00", "2019"));
    CompetitionSongList.Add(new OOPBasicProject.Song("Song 3", "Author 3", "3:00", "2018"));

    List<Competitor> competitionCompetitors = new List<Competitor>();
    competitionCompetitors.Add(new OOPBasicProject.Band("Maroon 5"));
    competitionCompetitors.Add(new OOPBasicProject.Band("Blink 182"));
    competitionCompetitors.Add(new OOPBasicProject.Band("Green Day"));
    competitionCompetitors.Add(new OOPBasicProject.Band("30 Seconds to Mars"));
    competitionCompetitors.Add(new OOPBasicProject.Band("Sum41"));
    competitionCompetitors.Add(new OOPBasicProject.Band("LMFAO"));
    competitionCompetitors.Add(new OOPBasicProject.Singer("safs"));
    Random random = new Random();    
    
    
    Helper.AddRandomCompetitors(competitionCompetitors, 10, "singer");
    Helper.AddRandomCompetitors(competitionCompetitors, 10, "band");
    
    Competitor absoluteWinner = Helper.GetAbsoluteWinner(Helper.GetVotesFromAudience(competitionCompetitors, Helper.MakeRandomAudienceList()));
    Console.WriteLine("The winner of the song competition is: " + absoluteWinner.CompetitorName);
    Console.ReadLine();
}
Part5();
//TODO - Part 5 - Create a new method that will create a new competition and will return the winner of the competition
//TODO bitsuim