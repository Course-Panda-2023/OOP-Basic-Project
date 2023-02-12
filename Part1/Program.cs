namespace MySingingContest
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Main1();
        }
        
        static void Main1()
        {
            Song badRomance = new Song("bad romance", "ra ra ooh la la");
            Singer gaga = new Singer("lady gaga", badRomance);
            Song hurt = new Song("hurt", "Ooh, ooh");
            Singer christina = new Singer("Christina", hurt);
            Judge simon = new Judge("Simon");
            simon.Duel(christina, gaga);
            Console.ReadLine();
        }
    }
}