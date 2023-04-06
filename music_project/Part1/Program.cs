// See https://aka.ms/new-console-template for more information
using contest;

ContestClass contest1 = new ContestClass();
contest1.Run2();


namespace contest
{
    class ContestClass
    {
        Judge SimonCowell = new Judge("Simon Cowell");
        List<Contestant> contestants = new List<Contestant>();

        /* Part 1
        Contestant Christina = new Contestant("Christina Aguilera");
        Contestant LadyGaga = new Contestant("Lady Gaga");
        */

        public void Init()
        {
            string[] names = { "Madonna", "Britney Spears", "Shakira", "Adele", "Avril Lavigne", "Nicki Minaj", "Ke$ha", "Kelly Clarkson", "Katy Perry", "Rihanna", "Beyoncé", "Justin Bieber", "Christina Aguilera", "Lady Gaga" };
            foreach (string name in names)
            {
                contestants.Add(new Contestant(name));
            }
        }

        /*
        public void Run1()
        {
            SimonCowell.RunContest(Christina, LadyGaga);
        }*/
        public void Run2()
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
