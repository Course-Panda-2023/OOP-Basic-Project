

public class Band: Competitor{

    string[] participants;

    public Band(MemberName name, string[] participants): base(name){
        this.participants = participants;
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