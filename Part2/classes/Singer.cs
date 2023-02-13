
using System;
using System.Threading;


public class Singer: Member{

    public Singer(MemberName name): base(name){
        if (Metadata.MemberNameToType[name] != MemberType.Singer){
            throw new Exception($"{name} is not a singer");
        }
    }

    public string StartSinging(string? SongName){

        if (SongName == null){
            SongName = Metadata.GetRandomSongName(this.name);
        } else {
            if (!Metadata.Songs[this.name.ToString()].ContainsKey(SongName)){
                throw new Exception($"Song {SongName} of singer {name} is not recognized");
            }
        }

        string lyrics = Metadata.Songs[this.name.ToString()][SongName];

        Console.WriteLine($"Let me, the beatiful singer {this.name} sing my song {SongName}");
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