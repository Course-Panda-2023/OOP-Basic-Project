
public class CrowdMember{
    private string name;

    public CrowdMember(string name){
        this.name = name;
    }

    public Singer ChooseWinner(Singer[] singers, string[] lyricses){
        Random rnd = new Random();
        int coin = rnd.Next(0, 2); 

        if (coin == 0){
            // choose winning singer randomly
            return singers[rnd.Next(0, singers.Length)];
        } else {
            // choose winning singer by length of lyrics he/she sang
            // derives the index of the winning lyric

            int[] lengths = lyricses.Select(l => l.Length).ToArray();
            int maxValue = lengths.Max();

            return singers[lengths.ToList().IndexOf(maxValue)];
        }
    }
}