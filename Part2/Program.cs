// See https://aka.ms/new-console-template for more information

/*
 * TODO: Copy all of your code from part1 and continue here.
 */

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
    //Dictionary<OOPBasicProject.Singer, int> voteCounts = new Dictionary<OOPBasicProject.Singer, int>();
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
    //while (pairs.Count < (temp_singers.Count * (temp_singers.Count - 1)) / 2)
    /*while (pairs.Count < singers.Count / 2)
    {
        int i = rnd.Next(0, singers.Count);
        int j = rnd.Next(0, singers.Count);

        // Make sure that the indices are different and that the pair doesn't already exist
        Tuple <OOPBasicProject.Singer, OOPBasicProject.Singer> singerCandidate = new Tuple<Singer, Singer>(singers[i], singers[j]); 
        if (i != j && !pairs.Contains(singerCandidate) && !singersIndexes.Contains(i) && !singersIndexes.Contains(j))
        {
            //pairs.Add(new Tuple<Singer, Singer>(singers[i], singers[j]));
            pairs.Add(singerCandidate);
            singersIndexes.Add(i);
            singersIndexes.Add(j);            
            Console.WriteLine($"{singers[i].ToString()}, {singers[j].ToString()}");           
        }
    }*/
    /*pairs = Helper.makeRandomPairs(singers);
    foreach(var pair in pairs)
    {
        Console.WriteLine("({0}, {1})", pair.Item1.ToString(), pair.Item2.ToString());
    }*/
    List<List<OOPBasicProject.Singer>> pairsList = Helper.makeRandomPairs(singers);
    List<Singer> finalists = new List<Singer>();
    foreach(var pair in pairsList)
    {
        Console.WriteLine("{0}, {1}", pair[0].ToString(), pair[1].ToString());
        finalists.Add(Helper.GetAbsoluteWinner(Helper.GetVotesFromJury(pair, juries)));
        //finalists.Add()
    }
    //Console.WriteLine("The winner of the song competition is: " + Helper.GetAbsoluteWinner(finalists).Name);
    Console.WriteLine();
    /*foreach(var finalist in finalists)
    {
        Console.WriteLine(finalist.Name);
    }*/
    pairsList = Helper.makeRandomPairs(finalists);
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
Part2();

/*static List<Tuple<int, int>> GetPairs(List<int> numbers)
{
    List<Tuple<int, int>> pairs = new List<Tuple<int, int>>();
    for (int i = 0; i < numbers.Count; i++)
    {
        for (int j = i + 1; j < numbers.Count; j++)
        {
            pairs.Add(Tuple.Create(numbers[i], numbers[j]));
        }
    }
    return pairs;
}

Part2();*/

