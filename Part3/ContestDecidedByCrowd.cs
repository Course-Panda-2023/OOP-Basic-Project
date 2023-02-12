using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class ContestDecidedByCrowd
{
    private List<Singer> mSingersList;
    public List<Singer> SingersList
    {
        get { return mSingersList; }
        set { mSingersList = value; }
    }
    public ContestDecidedByCrowd()
    {
        this.mSingersList = new List<Singer>();
    }
    public ContestDecidedByCrowd(List<Singer> list)
    {
        this.mSingersList = list;
    }
    public Singer SimulateRound()
    {
        Random rnd = new Random();
        if (this.mSingersList.Count > 1) 
        {
            Dictionary<Singer, int> dic = new Dictionary<Singer, int>();
            foreach (Singer singer in this.mSingersList)
                dic.Add(singer, 0);
            Console.WriteLine("Enter Crowd Number");
            int crowd = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < crowd; i++)
            {
                int choice = rnd.Next(0, this.mSingersList.Count);
                Singer s = dic.ElementAt(choice).Key;
                dic[s]++;
            }
            Singer loser = dic.Aggregate((l, r) => l.Value < r.Value ? l : r).Key;
            return loser;
        }
        return this.mSingersList[0];
    }
}