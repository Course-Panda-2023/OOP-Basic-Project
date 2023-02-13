namespace Music
{
    class Judge : Person
    {
        public Judge(string fullName) : base(fullName) { }
        public Singer ChoiceWinner(Singer singer1, Singer singer2)
        {
            Random rnd = new Random();  
            int win = rnd.Next(2);
            return win == 0 ? singer1 : singer2;
        }
    }
}