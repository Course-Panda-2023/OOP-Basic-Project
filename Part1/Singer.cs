public class Singer : Person
    {
        public Singer(string Name) : base(Name)
        {

        }

        public override void Sing(string lyric)
        {
            Console.WriteLine($"{this.Name}: {lyric}");
        }
    }

