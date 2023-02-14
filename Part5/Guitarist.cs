namespace Music
{
    class Guitarist : Person
    {
        public Guitarist(string fullName) : base(fullName) { }

        public void Action()
        {
            Console.WriteLine($"{this.GetFullName()} is playing now... ");
        }

    }
}