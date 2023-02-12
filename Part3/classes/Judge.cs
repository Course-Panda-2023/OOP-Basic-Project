
using System.Threading;

public class Judge: Member{
    
    public Judge(MemberName name): base(name) {
        if (Metadata.MemberNameToType[name] != MemberType.Judge){
            throw new Exception($"{name} is not a judge");
        }
    }

    public void StartCompetition(Singer[] singers, CrowdMember[] crowdMembers){
        Console.WriteLine("Welcome, lady's and gentelmen, to the amazinest competition that ever took place on earth!");
        Console.WriteLine($"Tonight, I {this.name}, am going to be your judge.");

        string[] lyricses = new string[singers.Length];
        int idx = 0;

        foreach(Singer singer in singers){
            Console.WriteLine($"{singer.name} it's your turn!");
            lyricses[idx] = singer.StartSinging();
            idx ++;
        }

        Singer[] choices = new Singer[crowdMembers.Length];
        idx = 0;

        Console.WriteLine("It's time for you, the crowd, to choose the winner!");

        foreach(CrowdMember crowdMember in crowdMembers){
            choices[idx] = crowdMember.ChooseWinner(singers, lyricses);
            idx ++;
        }

        Singer winner = this.DeriveWinner(choices);

        Console.Write("And the winner is");
        Thread.Sleep(500);
        Console.Write(".");
        Thread.Sleep(500);
        Console.Write(".");
        Thread.Sleep(500);
        Console.Write(".");
        Thread.Sleep(500);
        Console.WriteLine();
        Console.WriteLine($"{winner.name}");
    }

    public Singer DeriveWinner(Singer[] crowdChoices){
        Dictionary<Singer, int> count = new Dictionary<Singer, int>();

        foreach(Singer choice in crowdChoices){
            if (count.ContainsKey(choice)){
                count[choice] ++;
            } else {
                count[choice] = 1;
            }
        }

        Singer winner = count.Keys.ToArray()[0];
        int maxValue = count[winner];

        foreach(KeyValuePair<Singer, int> entry in count)
        {
            if (entry.Value > maxValue){
                maxValue = entry.Value;
                winner = entry.Key;
            }
        }

        return winner;
    }
}