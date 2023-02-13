public abstract class Person
{
    public string Name { get; set; }
    public Person(string Name)
    {
        this.Name = Name;
    }

    public virtual void Sing(string lyric)
    {
        Console.WriteLine($"{this.Name} is singing");
    }

    public virtual void PlayMusic()
    {
        Console.WriteLine($"{this.Name} is playing music");
    }

    //public virtual void PlayMusic()
    //{
    //    Console.WriteLine($"{this.Name} starts beatboxing");
    //}
}

