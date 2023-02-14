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

    List<OOPBasicProject.Singer> singers = new List<OOPBasicProject.Singer>();
    singers.Add(new OOPBasicProject.Singer("Ledy Gaga", 36, "New York", "USA"));
    singers.Add(new OOPBasicProject.Singer("Christina Aguilera", 42, "New York", "USA"));

    List<OOPBasicProject.Jury> juries = new List<OOPBasicProject.Jury>();
    juries.Add(new OOPBasicProject.Jury("Simon Cowell", 63, "London", "UK"));

    Helper.SelectingSongsBySingers(singers, CompetitionSongList);
    Singer absoluteWinner = Helper.GetAbsoluteWinner(Helper.GetVotesFromJury(singers, juries));

    Console.WriteLine("The winner of the song competition is: " + absoluteWinner.Name);
    Console.ReadLine();
}

//Part1();

static void Part2()
{
    List<OOPBasicProject.Song> CompetitionSongList = new List<OOPBasicProject.Song>();
    CompetitionSongList.Add(new OOPBasicProject.Song("Song 1", "Author 1", "3:00", "2019"));
    CompetitionSongList.Add(new OOPBasicProject.Song("Song 2", "Author 2", "3:00", "2018"));


    List<OOPBasicProject.Singer> singers = new List<OOPBasicProject.Singer>();
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
    
    List<List<OOPBasicProject.Singer>> pairsList = Helper.MakeRandomPairs(singers);
    List<Singer> finalists = new List<Singer>();
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
    Singer absoluteWinner = Helper.GetAbsoluteWinner(Helper.GetVotesFromJury(finalists, juries));
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

    List<OOPBasicProject.Singer> singers = new List<OOPBasicProject.Singer>();
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
    Helper.SelectingSongsBySingers(singers, CompetitionSongList);

    /*foreach (var a in audience)
    {
        //Console.WriteLine(a.ToString());
    }*/
    //Console.WriteLine(audience.Count);
    Singer absoluteWinner = Helper.GetAbsoluteWinner(Helper.GetVotesFromAudience(singers, audience));

    Console.WriteLine("The winner of the song competition is: " + absoluteWinner.Name);
    Console.ReadLine();
    
}

Part3();