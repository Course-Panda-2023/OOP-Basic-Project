namespace Music
{
    abstract class Competitor : Person
    {
        public Competitor(string fullName) : base(fullName) { }

        abstract public void Sing(string[] listSong);
    }
}