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
}