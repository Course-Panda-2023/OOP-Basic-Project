using System;
using System.Collections.Generic;  

class SingingCompetition
{
    public List<Singer> Singers;
    private Judge Judge;

    public SingingCompetition(List<Singer> singers, Judge judge)
    {
        this.Singers = singers;
        this.Judge = judge;
    }

    public Singer this[int index]
    {
        get {return Singers[index];}
        set {Singers[index] = value;}
    }

    public void AddSinger(Singer singer)
    {
        this.Singers.Add(singer);
    }
    

    public virtual void RunCompetition()
    {
        Console.WriteLine("Competition will now commence!");
        for (int i=0; i<this.Singers.Count; i++)
        {
            Singer singer = this[i];
            singer.ChooseSong();
        }
        Console.WriteLine($"Judge {this.Judge.Name} will now decide who the winner is.");
        Console.WriteLine("'Drum roll please...'");

        Judge.ChooseWinner(this.Singers);
        

    }
}
