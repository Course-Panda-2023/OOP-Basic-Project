
public class Metadata{
    
    public static Dictionary<string, string> Songs = new Dictionary<string, string>{
        {"Beautiful", "Don't look at me"},
        {"Pero Me Acuerdo de Tí", "Ahora que ya mi vida se encuentra normal"},
        {"Bloody Mary", "Love is just a history that they may prove"}
    };

    public static string GetRandomSongName(){
        string[] songNames = Songs.Keys.ToArray();

        Random random = new Random();
        return songNames[random.Next(0, songNames.Length)];
    }
}