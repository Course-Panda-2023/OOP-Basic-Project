namespace Music
{
    class Singer : Person
    {
        public Singer(string firstName, string lastName) : base(firstName, lastName) { }
        
        public void Sing(string songName)
        {
            Console.WriteLine($"{_firstName} {_lastName} is singing `{songName}` now... ");
        }

    }
}