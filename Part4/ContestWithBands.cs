using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class ContestWithBands
{
    private List<ContestParticipant> mParticipantsList;
    public List<ContestParticipant> ParticipantsList
    {
        get { return mParticipantsList; }
        set { mParticipantsList = value; }
    }
    public ContestWithBands()
    {
        this.mParticipantsList = new List<ContestParticipant>();
    }
    public ContestWithBands(List<ContestParticipant> list)
    {
        this.mParticipantsList = list;
    }
    public ContestParticipant SimulateRound()
    {
        Random rnd = new Random();
        if (this.mParticipantsList.Count > 1)
        {
            Dictionary<ContestParticipant, int> dic = new Dictionary<ContestParticipant, int>();
            foreach (ContestParticipant singer in this.mParticipantsList)
                dic.Add(singer, 0);
            Console.WriteLine("Enter Crowd Number");
            int crowd = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < crowd; i++)
            {
                int choice = rnd.Next(0, this.mParticipantsList.Count);
                ContestParticipant s = dic.ElementAt(choice).Key;
                dic[s]++;
            }
            ContestParticipant loser = dic.Aggregate((l, r) => l.Value < r.Value ? l : r).Key;
            return loser;
        }
        return this.mParticipantsList[0];
    }
}