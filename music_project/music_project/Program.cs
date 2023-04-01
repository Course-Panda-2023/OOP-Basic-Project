// See https://aka.ms/new-console-template for more information
using contest;

ContestClass contest1 = new ContestClass();
contest1.Run();
Console.ReadKey();

namespace contest
{
    class ContestClass
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
