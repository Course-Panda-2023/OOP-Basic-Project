using System.Collections.Generic;  

class Singer : Person
{
    public List<Song> songs = new List<Song>();
    private int numOfFans;
    public Singer(string name, uint age, List<Song> songs, int numOfFans) : base(name, age)
    {
        this.songs = songs;
        this.numOfFans = numOfFans;
    }

    public void addSong(Song song)
    {
        this.songs.Add(song);
    }
}