

public class Band: Competitor{

    public Band(string bandName, Musician members): base(bandName){
        this.members = members;
    }

    public override string StartSinging(){
        string songName = Metadata.GetRandomSongName(this.name);
        string lyrics = Metadata.Songs[songName];

        Console.WriteLine($"Let us, the wonderful band {this.name} sing the song {songName}");
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