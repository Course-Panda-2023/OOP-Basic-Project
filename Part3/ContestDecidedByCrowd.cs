using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class ContestDecidedByCrowd
{
    private List<Singer> mParticipantsList;
    public List<Singer> SingersList
    {
        get { return mParticipantsList; }
        set { mParticipantsList = value; }
    }
    public ContestDecidedByCrowd()
    {
        this.mParticipantsList = new List<Singer>();
    }
    public ContestDecidedByCrowd(List<Singer> list)
    {
        this.mParticipantsList = list;
    }
    public Singer SimulateRound()
    {
        Random rnd = new Random();
        if (this.mParticipantsList.Count > 1) 
        {
            Dictionary<Singer, int> dic = new Dictionary<Singer, int>();
            foreach (Singer singer in this.mParticipantsList)
                dic.Add(singer, 0);
            Console.WriteLine("Enter Crowd Number");
            int crowd = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < crowd; i++)
            {
                int choice = rnd.Next(0, this.mParticipantsList.Count);
                Singer s = dic.ElementAt(choice).Key;
                dic[s]++;
            }
            Singer loser = dic.Aggregate((l, r) => l.Value < r.Value ? l : r).Key;
            return loser;
        }
        return this.mParticipantsList[0];
    }
}