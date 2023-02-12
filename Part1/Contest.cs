using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Contest
{
    private Judge mContestJudge;
    public Judge ContestJudge
    {
        get { return mContestJudge; }
        set { mContestJudge = value; }
    }
    private Singer mFirstSinger;
    public Singer FirstSinger
    {
        get { return mFirstSinger; }
        set { mFirstSinger = value; }
    }
    private Singer mSecondSinger;
    public Singer SecondSinger
    {
        get { return mSecondSinger; }
        set { mSecondSinger = value; }
    }
    private int mFirstSingerPoints;
    public int FirstSingerPoints
    {
        get { return mFirstSingerPoints; }
        set { mFirstSingerPoints = value; }
    }
    private int mSecondSingerPoints;
    public int SecondSingerPoints
    {
        get { return mSecondSingerPoints; }
        set { mSecondSingerPoints = value; }
    }
    public Contest(Judge contestJudge, Singer firstSinger, Singer secondSinger)
    {
        this.mContestJudge = contestJudge;
        this.mFirstSinger = firstSinger;
        this.mSecondSinger = secondSinger;
        this.mFirstSingerPoints = 0;
        this.mSecondSingerPoints = 0;    
    }
    public void SimulateRound()
    {
        Random rnd = new Random();
        int firstIndex = rnd.Next(0,this.mFirstSinger.SongsList.Count);
        int secondIndex = rnd.Next(0,this.mSecondSinger.SongsList.Count);
        Console.WriteLine(this.mFirstSinger.Name + " Sings: " + this.mFirstSinger.SongsList[firstIndex]);
        Console.WriteLine(this.mSecondSinger.Name + " Sings: " + this.mSecondSinger.SongsList[secondIndex]);
        int num = rnd.Next(1, 3);
        switch (num)
        {
            case 1:
                this.mFirstSingerPoints++;
                Console.WriteLine(this.mFirstSinger.Name + " Wins This Round!");
                break;
            case 2:
                this.mSecondSingerPoints++;
                Console.WriteLine(this.mSecondSinger.Name + " Wins This Round!");
                break;
            default:
                break;
        }
    }
    public void PrintLeadingSinger()
    {
        if (this.mFirstSingerPoints == this.mSecondSingerPoints)
            Console.WriteLine("Its Tied Between " + this.mFirstSinger.Name + " And, " + this.mSecondSinger.Name);
        else if (this.mFirstSingerPoints > this.mSecondSingerPoints)
            Console.WriteLine(this.mFirstSinger.Name + " Is Leading");
        else
            Console.WriteLine(this.mSecondSinger.Name + " Is Leading");
    }
}