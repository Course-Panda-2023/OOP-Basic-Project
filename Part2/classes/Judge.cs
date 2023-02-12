
using System.Threading;

public class Judge: Member{
    
    public Judge(MemberName name): base(name) {
        if (Metadata.MemberNameToType[name] != MemberType.Judge){
            throw new Exception($"{name} is not a judge");
        }
    }

    public void StartCompetition(Singer[] Singers){
        Console.WriteLine("Welcome, lady's and gentelmen, to the amazinest competition that ever took place on earth!");
        Console.WriteLine($"Tonight, I {this.name}, am going to be your judge.");

        int numSingers = Singers.Length;

        Singer? winner = null;  // the 'null' is only needed for compilation. 
        int winnerScore = 0;

        Random random = new Random();

        while (Singers.Length > 0 ){
            Console.WriteLine("A new random singer is being drawn right now!");
            Thread.Sleep(500);
            Singer randomSinger = Singers[random.Next(0, Singers.Length)];
            Console.WriteLine($"Singer {randomSinger.name} was chosen!");
            int lyricsLength = randomSinger.StartSinging(null).Length;

            if (Singers.Length != numSingers){
                // this is not the first round
                if (winnerScore < lyricsLength){
                    winner = randomSinger;
                    winnerScore = lyricsLength;
                }

                Console.WriteLine($"And the winner is {winner.name}");
            } else {
                winner = randomSinger;
                winnerScore = lyricsLength;
            }

            Singers = Singers.Where(val => val != randomSinger).ToArray();
        }
    }
}