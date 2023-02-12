// See https://aka.ms/new-console-template for more information

/*
 * TODO: Write code for part1.
 * Notice: You need to implement the project structure yourself.
 */
string song = "Seems like it was yesterday\r\nWhen I saw your face\r\nYou told me how proud you were,\r\nBut I walked away\r\nIf only I knew what I know today\r\nOoh, ooh";
string song1 = "A RedOne\r\nConvict\r\nGaga\r\n\r\nI've had a little bit too much\r\nAll of the people start to rush\r\n(Start to rush by)\r\n\r\nCaught in a twisted dance\r\nCan't find my drink or man\r\nWhere are my keys, I left my phone";
Song ChristinaAguileraSong = new Song("Hurt", song);
Song LadyGagaSong = new Song("Just Dance", song1);
Singer LadyGaga = new Singer("Lady", "Gaga");
Singer ChristinaAguilera = new Singer("Christina", "Aguilera");
Judge SimonCowell = new Judge("Simon", " Cowell");
LadyGaga.addSong(LadyGagaSong);
ChristinaAguilera.addSong(ChristinaAguileraSong);
List<Singer> singers1 = new List<Singer>();
singers1.Add(LadyGaga);
singers1.Add(ChristinaAguilera);
SimonCowell.manageCompetition(singers1);


class Person
{
    private string firstName;
    private string lastName;
    public string FirstName
    {
        get
        {
            return firstName; 
        }
        set
        {
            this.firstName = value;
        }
    }
    public string LastName
    {
        get
        {
            return this.lastName;
        }
        set 
        {
            this.lastName = value;
        }
    }
    public override string ToString()
    {
        return $"{this.firstName} {this.lastName}";
    }
    public Person(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }
}
class Song
{
    private string word;
    private string name;
    public Song(string name, string word)
    {
        this.word = word;
        this.name = name;
    }
    public override string ToString()
    {
        return $"The name of the song is {this.name} And his words are {this.word}";
    }

}
class Singer : Person
{
    List<Song> songs;
    static Random rnd = new Random();//A variable that helps select songs randomly
    public Singer(string firstName, string lastName) : base(firstName, lastName)
    {
        this.songs = new List<Song>();

    }

    public void addSong(Song song)
    {
        songs.Add(song);
    }

    public void removeSong(Song song)
    {
        songs.Remove(song);
    }

    public Song singSong()
    {
        int r = rnd.Next(songs.Count);
        return songs[r];
    }
}

class Judge : Person
{
    static Random rnd = new Random();//A variable that helps select Winner randomly
    public Judge(string firstName, string lastName) : base(firstName, lastName)
    {

    }
    private Singer ChooseWinner(List<Singer> singers)
    {
        int r = rnd.Next(singers.Count);
        return singers[r];
    }
    public void manageCompetition(List<Singer> singers)
    {
        Song song;
        foreach (Singer singer in singers)
        {
            song = singer.singSong();
            Console.WriteLine($"And now the singer {singer} will sing: ");
            Console.WriteLine(song);
        }
        Singer winner = this.ChooseWinner(singers);
        Console.WriteLine($"And the winner is {winner}");
    }
}
Console.ReadLine();