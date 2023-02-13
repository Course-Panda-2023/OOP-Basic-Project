
using System;
using System.Threading;

public class Judge: Member{
    
    public Judge(string name): base(name) {
        
    }

    public void StartCompetition(Competitor[] competitors, CrowdMember[] crowdMembers){
        foreach(Competitor competitor in competitors){
            if ((! (competitor is Singer)) & (! (competitor is Band))){
                throw new Exception("Competitors must be from type Singer or Band");
            }
        }

        Console.WriteLine("Welcome, lady's and gentelmen, to the amazinest competition that ever took place on earth!");
        Console.WriteLine($"Tonight, I {this.name}, am going to be your judge.");

        string[] lyricses = new string[competitors.Length];
        int idx = 0;

        foreach(Competitor competitor in competitors) {
            Console.WriteLine($"{competitor.name} it's your turn!");
            if (competitor is Singer){
                Singer singer = (Singer) competitor;
                lyricses[idx] = singer.StartSinging();
            } else {
                // competitor is of type Band
                Band band = (Band) competitor;
                lyricses[idx] = band.StartSinging();
            }
            
            idx ++;
        }

        Competitor[] choices = new Competitor[crowdMembers.Length];
        idx = 0;

        Console.WriteLine("It's time for you, the crowd, to choose the winner!");

        foreach(CrowdMember crowdMember in crowdMembers){
            choices[idx] = crowdMember.ChooseWinner(competitors, lyricses);
            idx ++;
        }

        Competitor winner = this.DeriveWinner(choices);

        Console.Write("And the winner/s is/are");
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

    public Competitor DeriveWinner(Competitor[] crowdChoices){
        Dictionary<Competitor, int> count = new Dictionary<Competitor, int>();

        foreach(Competitor choice in crowdChoices){
            if (count.ContainsKey(choice)){
                count[choice] ++;
            } else {
                count[choice] = 1;
            }
        }

        Competitor winner = count.Keys.ToArray()[0];
        int maxValue = count[winner];

        foreach(KeyValuePair<Competitor, int> entry in count)
        {
            if (entry.Value > maxValue){
                maxValue = entry.Value;
                winner = entry.Key;
            }
        }

        return winner;
    }
}