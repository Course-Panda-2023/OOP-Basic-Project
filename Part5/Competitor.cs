namespace Music
{
    abstract class Competitor : Person
    {
        public Competitor(string fullName) : base(fullName) { }

        abstract public void Action(string[] listSong);

        abstract public void Action(string songName);
    }
}