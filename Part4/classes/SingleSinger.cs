

public class SingleSinger: Competitor{

    public SingleSinger(MemberName name): base(name){

    }

    public override string StartSinging(){
        string songName = Metadata.GetRandomSongName(this.name);
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