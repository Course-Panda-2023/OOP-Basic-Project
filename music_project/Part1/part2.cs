// See https://aka.ms/new-console-template for more information
using contest;

//ContestClass1 contest1 = new ContestClass1();
//contest1.Run();
//ContestClass2 contest2 = new ContestClass2();
//contest2.Run();
ContestClass3 contest3 = new ContestClass4();
contest3.Run();


namespace contest
{
    public class ContestClass2
    {
        Judge SimonCowell = new Judge("Simon Cowell");
        protected List<Contestant> contestants = new List<Contestant>();

        public virtual void Init()
        {
            string[] names = { "Madonna", "Britney Spears", "Shakira", "Adele", "Avril Lavigne", "Nicki Minaj", "Ke$ha", "Kelly Clarkson", "Katy Perry", "Rihanna", "Beyoncé", "Justin Bieber", "Christina Aguilera", "Lady Gaga" };
            foreach (string name in names)
            {
                contestants.Add(new Contestant(name));
            }
        }
        
        public virtual void Run()
        {
            Init();
            while (contestants.Count > 1)
            {
                Compete();
            }
            Console.WriteLine("Champion of the tornemant is " + contestants[0].name);
        }

        private void Compete()
        {
            // draw contestants
            var random = new Random();
            int index1 = random.Next(contestants.Count);
            int index2;
            do
            {
                index2 = random.Next(contestants.Count);
            } while (index1 == index2);

            //
            Contestant loser = SimonCowell.RunContest(contestants[index1], contestants[index2]);
            contestants.Remove(loser);
        }
    }

}
