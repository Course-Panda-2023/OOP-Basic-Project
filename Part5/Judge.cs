
class Judge : Person
{
    public Judge(string name, uint age) : base(name, age)
    {
    }
    public void ChooseWinner(List<Singer> singers)
    {
        Random rand = new Random();
        int winnerIndex = rand.Next(0, singers.Count);
        Console.WriteLine($"Singer {singers[winnerIndex].Name} has won!");
    }
}