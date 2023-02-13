namespace Music
{
    class Judge : Person
    {
        public Judge(string firstName, string lastName) : base(firstName, lastName) { }
        public string ChoiceWinner(Singer singer1, Singer singer2)
        {
            Random rnd = new Random();  
            int win = rnd.Next(2);
            return win == 0 ? singer1.GetFullName() : singer2.GetFullName();
        }
    }
}