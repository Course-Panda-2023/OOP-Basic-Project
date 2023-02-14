using System.Collections.Generic;  

class Singer : Competitor
{
    private int Age;
    public Singer(string name, List<Song> songs, int numOfFans, int age) : base(name, songs, numOfFans)
    {
        this.Age = age;
    }

    public void ChooseSong()
    {
        Random rand = new Random();
        Console.WriteLine($"Singer {this.Name} will now choose a song.");
        int songIndex = rand.Next(0, this.Songs.Count);
        Song song = this.Songs[songIndex];
        Console.WriteLine($"The song performed will be {song.Name}");
        Console.WriteLine($"{this.Name}: '{song.Lyrics}'");
        Console.WriteLine("");
    }

    public override bool IsValid()
    {
        if (this.Songs.Count == 0)
        {
            Console.WriteLine("Singer has no songs");
            return false;
        }
        else
            return true;
    }
}