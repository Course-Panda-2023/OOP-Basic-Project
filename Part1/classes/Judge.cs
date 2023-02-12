
public class Judge: Member{
    
    public Judge(MemberName name): base(name) {
        if (Metadata.MemberNameToType[name] != MemberType.Judge){
            throw new Exception($"{name} is not a judge");
        }
    }

    public void StartCompetition(Singer[] Singers){
        Console.WriteLine("Welcome, ladys and gentelmen, to the amazinest competition that ever took place on earth!");
        Console.WriteLine($"Tonight, I {this.name}, am going to be your judge.");

        string[] lyricses = new string[Singers.Length];
        int i = 0;
        
        foreach(Singer singer in Singers){
            Console.WriteLine($"{singer.name} it's your turn!");
            lyricses[i] = singer.StartSinging(null);  // sing a random song
            i ++;
        }

        MemberName winnerName = Singers[this.DeriveWinner(lyricses)].name;
        Console.WriteLine($"And the winner is {winnerName}, only because the song she sang was longer!");
    }

    public int DeriveWinner(string[] lyricses){
        // derives the index of the winning lyric

        int[] lengths = lyricses.Select(l => l.Length).ToArray();
        int maxValue = lengths.Max();

        return lengths.ToList().IndexOf(maxValue);
    }
}