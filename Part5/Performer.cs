public interface Performer
{
    string Name { get; }

    void Perform();

    void PerformSong(Song song);

    void PerformOneOfThree();

    void AddSong(Song song);

    void AddList(Song[] songs);

}
