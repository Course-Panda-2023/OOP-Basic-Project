using System;

class Judge
{
    private string mName;
    public string Name
    {
        get { return mName; }
        set { mName = value; }
    }

    public Judge(string name)
    {
        mName= name;
    }

    public void JudgePerformance()
    {
        string[] options = {
            "I'm sorry, that stinked....",
            "WOW!!! I don't think i've ever heard something so trash", 
            "I'd rather step on legos than hear anything come out of your mouth again",
            "This performance would be amazing, if I were only deaf",
            "I'm crying... And you can bet it's not tears of joy"
        };
        Console.Write($"{mName}: ");
        Random ran = new Random();
        int option = ran.Next(0, options.Length - 1);
        Console.WriteLine(options[option] + "\n");

    }
    public void ChooseWinner(Singer singer1, Singer singer2)
    {
        Random ran = new Random();
        int winnerIndex = ran.Next(1, 3); //1 for singer 1...
        Console.WriteLine($"{mName}: This might have been the worst thing I've had to endure, but if I had to pick it would be");
        switch (winnerIndex)
        {
            case 1:
                Console.WriteLine($"{singer1.Name}!!!!!");
                break;
            case 2:
                Console.WriteLine($"{singer2.Name}!!!!!");
                break;
            default:
                break;
        }
    }

    public static void Competition(Singer[] singers)
    {
        int newListLength = (int) Math.Ceiling((double) singers.Length/2);
        if (singers.Length == 1)
        {
            Console.WriteLine($"And the overall winner is: {singers[0].Name}!!");
        }
        else
        {
            Console.WriteLine("This round's winners are: \n");
            Singer[] newList = new Singer[newListLength];
            for (int i = 0; i < singers.Length - 1; i += 2)
            {
                singers[i].Perform();
                singers[i+1].Perform();
                Random ran = new Random();
                int choice = ran.Next(i, i+2);
                newList[i/2] = singers[choice];
                Console.WriteLine($"{singers[i].Name} vs. {singers[i + 1].Name}: {singers[choice].Name}");
            }
            if (newListLength != 1)
            {
                newList[newListLength - 1] = singers[singers.Length - 1];
            }
            Competition(newList);
        }
    }
}