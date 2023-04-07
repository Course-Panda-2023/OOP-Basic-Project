using contest;

namespace contest
{
    class ContestClass1
    {
        Judge SimonCowell = new Judge("Simon Cowell");

        Contestant Christina = new Contestant("Christina Aguilera");
        Contestant LadyGaga = new Contestant("Lady Gaga");
        public void Run()
        {
            SimonCowell.RunContest(Christina, LadyGaga);
        }
    }
}