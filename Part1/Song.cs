
class Song
{
    public string? name;
    private uint duration; // in seconds
    private uint year;
    Person songwriter;
    

    public Song(string name, uint duration, uint year, Person songwriter)
    {
        this.name = name;
        this.duration = duration;
        this.year = year;
        this.songwriter = songwriter;
    }

}