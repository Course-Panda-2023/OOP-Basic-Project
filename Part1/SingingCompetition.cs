using System;
using System.Collections.Generic;  

class SingingCompetition
{
    Random rand = new Random();
    private List<Singer> singers;
    private Judge judge;

    public SingingCompetition(List<Singer> singers, Judge judge)
    {
        this.singers = singers;
        this.judge = judge;
    }

    public Singer this[int index]
    {
        get {return singers[index];}
        set {singers[index] = value;}
    }

    public void addSinger(Singer singer)
    {
        this.singers.Add(singer);
    }
    

    public void RunCompetition()
    {
        Console.WriteLine("Competition will now commence!");
        for (int i=0; i<this.singers.Count; i++)
        {
            Console.WriteLine($"Singer {this[i].name} will now sing.");
            int songIndex = rand.Next(0, this[i].songs.Count);
            Console.WriteLine($"The song performed will be {this[i].songs[songIndex].name}");
            // #TODO add here a little bit of lyrics (core song level attribute)
            Console.WriteLine("");
        }
        Console.WriteLine($"Judge {this.judge.name} will now decide who the winner is.");
        Console.WriteLine("'Drum roll please...'");
        int winnerIndex = rand.Next(0, this.singers.Count);
        Console.WriteLine($"Singer {this[winnerIndex].name} has won!");

    }
}
