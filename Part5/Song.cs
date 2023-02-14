
class Song
{
    public string Name;
    private int DurationInSeconds; 
    private int Year;
    public string Lyrics;
    Person Songwriter;
    

    public Song(string name, int duration, int year, string Lyrics, Person songwriter)
    {
        this.Name = name;
        this.DurationInSeconds = duration;
        this.Year = year;
        this.Songwriter = songwriter;
        this.Lyrics = Lyrics;
    }



}