

public class Singer: Musician{

    public Singer(string name): base(name){

    }

    public string StartSinging(){
        string songName = Metadata.GetRandomSongName();
        string lyrics = Metadata.Songs[songName];

        Console.WriteLine($"Let me, the beatiful singer {this.name} sing the song {songName}");
        Thread.Sleep(500);
        Console.Write(lyrics);
        Console.Write(".");
        Thread.Sleep(500);
        Console.Write(".");
        Thread.Sleep(500);
        Console.Write(".");
        Thread.Sleep(500);
        Console.WriteLine();

        return lyrics;
    }
}