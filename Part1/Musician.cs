public class Musician : Person
    {
        private string Insturment { get; set; }
        public Musician(string Name, string insturment) : base(Name)
        {
            this.Insturment = insturment;
        }

        public override void PlayMusic()
        {
            Console.WriteLine($"{this.Name} plays the {this.Insturment}");
        }
    }
public class Drummer : Musician
{
    public Drummer(string Name) : base(Name, "Drums")
    {
    }
}

public class Guitarist : Musician
{
    public Guitarist(string Name) : base(Name, "Guitar")
    {
    }
}
