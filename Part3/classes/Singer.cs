
using System;
using System.Threading;


public class Singer: Member{

    public Singer(MemberName name): base(name){
        if (Metadata.MemberNameToType[name] != MemberType.Singer){
            throw new Exception($"{name} is not a singer");
        }
    }

    public string StartSinging(){
        string songName = Metadata.GetRandomSongName(this.name);
        string lyrics = Metadata.Songs[songName];

        Console.WriteLine($"Let me, the beatiful singer {this.name} sing my song {songName}");
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