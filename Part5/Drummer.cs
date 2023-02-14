namespace Music
{
    class Drummer : Person
    {
        public Drummer(string fullName) : base(fullName) { }

        public void Action()
        {
            Console.WriteLine($"{this.GetFullName()} is drumming now... ");
        }
    }
}