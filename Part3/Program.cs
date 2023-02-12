// See https://aka.ms/new-console-template for more information

/*
 * TODO: Copy all of your code from part2 and continue here.
 */
//// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;
using System.Xml.Linq;

string song = "Seems like it was yesterday\r\nWhen I saw your face\r\nYou told me how proud you were,\r\nBut I walked away\r\nIf only I knew what I know today\r\nOoh, ooh";
string song1 = "A RedOne\r\nConvict\r\nGaga\r\n\r\nI've had a little bit too much\r\nAll of the people start to rush\r\n(Start to rush by)\r\n\r\nCaught in a twisted dance\r\nCan't find my drink or man\r\nWhere are my keys, I left my phone";
Song ChristinaAguileraSong = new Song("Hurt", song);
Song LadyGagaSong = new Song("Just Dance", song1);
Singer LadyGaga = new Singer("Lady", "Gaga");
Singer ChristinaAguilera = new Singer("Christina", "Aguilera");
Judge SimonCowell = new Judge("Simon", " Cowell");
LadyGaga.addSong(LadyGagaSong);
ChristinaAguilera.addSong(ChristinaAguileraSong);
string song13 = "You know you love me (yo), I know you care (uh-huh)\r\nJust shout whenever (yo), and I'll be there (uh-huh)\r\nYou are my love (yo), you are my heart (uh-huh)\r\nAnd we will never, ever, ever be apart (yo, uh-huh)";
Song JustinBieberSong = new Song("Baby", song13);
Singer JustinBieber = new Singer("Justin", "Bieber");
JustinBieber.addSong(JustinBieberSong);
List<Singer> singers1 = new List<Singer>();
//singers1.Add(LadyGaga);
//singers1.Add(ChristinaAguilera);
//singers1.Add(JustinBieber);
SimonCowell.Competition(singers1);
List<Voter> voter1 = new List<Voter>
{
    new Voter("aa","bb"),
    new Voter("aa","bb"),
    new Voter("aa","bb"),
    new Voter("aa","bb")
};
Competition competition1 = new Competition();
competition1.competitionWithVotes(voter1, singers1, new List<Song> { JustinBieberSong });
class Competition
{
    public Competition()
    {
    }

    public void competitionWithjudge(Judge judge, List<Singer> singers)
    {
        judge.Competition(singers);
    }

    private Dictionary<Singer, int> initVoteDict(List<Singer> singers)
    {
        Dictionary<Singer, int> voteDict = new Dictionary<Singer, int>();
        foreach (Singer singer in singers)
        {
            voteDict.Add(singer, 0);
        }
        return voteDict;
    }
    private Dictionary<Singer, int> removeLosser(int max, Dictionary<Singer, int> voteDict)
    {
        foreach (KeyValuePair<Singer, int> kvp in voteDict)
        {
            if (kvp.Value < max)
            {
                voteDict.Remove(kvp.Key);
            }
        }
        return voteDict;
    }
    private int maxVoted(Dictionary<Singer, int> voteDict)
    {
        int max = -1;
        foreach (KeyValuePair<Singer, int> kvp in voteDict)
        {
            if (kvp.Value > max)
            {
                max = kvp.Value;
            }
        }
        return max;
    }
    private List<Singer> dictTolist(Dictionary<Singer, int> voteDict)
    {
        List<Singer> singers = new List<Singer>();
        foreach (KeyValuePair<Singer, int> kvp in voteDict)
        {
            singers.Add(kvp.Key);
        }
        return singers;
    }
    public void competitionWithVotes(List<Voter> voters, List<Singer> singers, List<Song> songs)
    {
        Song song;
        Dictionary<Singer, int> voteDict = this.initVoteDict(singers);
        foreach (Singer singer in singers)
        {
            song = singer.singSong(songs);
            Console.WriteLine($"And now the singer {singer} will sing: ");
            Console.WriteLine(song);
        }
        foreach (Voter voter in voters)
        {
            voteDict[voter.chooseWinner(singers)] += 1;
        }
        int max = maxVoted(voteDict);
        voteDict = this.removeLosser(max, voteDict);
        if (voteDict.Count == 1)
        {
            Console.WriteLine($"the winner is: {voteDict.ElementAt(0).Key}");
            return;
        }
        //in case of tie
        this.competitionWithVotes(voters, this.dictTolist(voteDict), songs);
    }
}
class Person
{
    private string firstName;
    private string lastName;
    public string FirstName
    {
        get { return firstName; }
        set { this.firstName = value; }
    }
    public string LastName
    {
        get { return this.lastName; }
        set { this.lastName = value; }
    }
    public override string ToString()
    {
        return $"{this.firstName} {this.lastName}";
    }
    public Person(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }
}
class Voter : Person
{
    static Random rnd = new Random();//A variable that helps select winner randomly
    public Voter(string firstName, string lastName) : base(firstName, lastName) { }
    public Singer chooseWinner(List<Singer> singers)
    {

        int r = rnd.Next(singers.Count);
        return singers[r];
    }
}
class Song
{
    private string word;
    private string name;
    public Song(string name, string word)
    {
        this.word = word;
        this.name = name;
    }
    public override string ToString()
    {
        return $"The name of the song is {this.name} And his words are {this.word}";
    }

}
class Singer : Person
{
    List<Song> songs;
    static Random rnd = new Random();//A variable that helps select songs randomly
    public Singer(string firstName, string lastName) : base(firstName, lastName)
    {
        this.songs = new List<Song>();

    }

    public void addSong(Song song)
    {
        songs.Add(song);
    }

    public void removeSong(Song song)
    {
        songs.Remove(song);
    }

    public Song singSong()
    {
        int r = rnd.Next(songs.Count);
        return songs[r];
    }
    public Song singSong(List<Song> songsArr)
    {
        int r = rnd.Next(songsArr.Count);
        return songs[r];
    }
}

class Judge : Person
{
    static Random rnd = new Random();//A variable that helps select Winner randomly
    public Judge(string firstName, string lastName) : base(firstName, lastName)
    {

    }
    private Singer ChooseWinner(List<Singer> singers)
    {
        int r = rnd.Next(singers.Count);
        return singers[r];
    }
    public Singer manageCompetition(List<Singer> singers)
    {
        //this func return the loser in Duel
        Song song;
        foreach (Singer singer in singers)
        {
            song = singer.singSong();
            Console.WriteLine($"And now the singer {singer} will sing: ");
            Console.WriteLine(song);
        }
        Singer winner = this.ChooseWinner(singers);
        Console.WriteLine($"And the winner is {winner}");
        return winner == singers[0] ? singers[1] : singers[0];
    }
    private List<Singer> getCompeting(List<Singer> singers)
    {
        int ranNum1 = rnd.Next(singers.Count);
        int ranNum2 = rnd.Next(singers.Count);
        while (ranNum2 == ranNum1)
            ranNum2 = rnd.Next(singers.Count);
        return new List<Singer> { singers[ranNum1], singers[ranNum2] };

    }
    public void Competition(List<Singer> singers)
    {
        while (singers.Count != 1)
        {
            List<Singer> competing = this.getCompeting(singers);
            Singer looser = this.manageCompetition(competing);
            singers.Remove(looser);
        }
        Console.WriteLine($"The winner of the competition is {singers[0]}");
    }
}

