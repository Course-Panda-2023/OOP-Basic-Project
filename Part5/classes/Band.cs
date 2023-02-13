
using System;


public class Band: Competitor{

    public Band(string bandName, Musician[] members): base(bandName){

        bool containsSinger = false, containsDrummer = false, containsGuitarist = false;

        foreach(Musician member in members){
            if (member is Singer){
                containsSinger = true;
            } else {
                if (member is Guitarist){
                    containsGuitarist = true;
                } else {
                    containsDrummer = true;
                }
            }
        }

        if ((! containsSinger) | (! containsGuitarist) | (! containsDrummer)){
            throw new Exception("Band must include at least one singer, guitarist and drummer");
        }
    }

    public string StartSinging(){
        string songName = Metadata.GetRandomSongName();
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