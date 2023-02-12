namespace MySingingContest
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Song badRomance = new Song("bad romance", "ra ra ooh la la");
            Song[] gagaSongs = new Song[] { badRomance };
            Singer gaga = new Singer("lady gaga", gagaSongs);
            Song hurt = new Song("hurt", "Ooh, ooh");
            Song[] christinaSongs = new Song[] { hurt };
            Singer christina = new Singer("Christina", christinaSongs);
            Judge simon = new Judge("Simon");
            Singer[] singers = { christina, gaga };
            Singer winner = simon.ChooseWinner(singers);
            simon.AnnounceWinner(winner);
            
        }
    }
}