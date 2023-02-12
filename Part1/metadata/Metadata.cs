
public class Metadata{
    
    public static Dictionary<string, string> ChristinaAguileraSongs = new Dictionary<string, string>{
        {"Beautiful", "Don't look at me"},
        {"Pero Me Acuerdo de Tí", "Ahora que ya mi vida se encuentra normal"}
    };

    public static Dictionary<string, string> LadyGagaSongs = new Dictionary<string, string>{
        {"Bloody Mary", "Love is just a history that they may prove"},
        {"Always Remember Us This Way", "That Arizona sky burnin' in your eyes"}
    };

    public static Dictionary<MemberName, Dictionary<string, string>> Songs = new Dictionary<MemberName, Dictionary<string, string>>{
        {MemberName.CHRISTINA_AGUILERA, ChristinaAguileraSongs},
        {MemberName.LADY_GAGA, LadyGagaSongs}
    };

    public static string GetRandomSongName(MemberName name){
        string[] songNames = Metadata.Songs[name].Keys.ToArray();

        Random random = new Random();
        return songNames[random.Next(0, songNames.Length)];
    }
}