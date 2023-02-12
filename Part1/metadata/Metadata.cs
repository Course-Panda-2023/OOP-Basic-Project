
public class Metadata{
    
    public static Dictionary<string, string> ChristinaAguileraSongs = new Dictionary<string, string>{
        {"Beautiful", "Don't look at me"},
        {"Pero Me Acuerdo de Tí", "Ahora que ya mi vida se encuentra normal"}
    };

    public static Dictionary<string, string> LadyGagaSongs = new Dictionary<string, string>{
        {"Bloody Mary", "Love is just a history that they may prove"},
        {"Always Remember Us This Way", "That Arizona sky burnin' in your eyes"}
    };

    public static Dictionary<string, Dictionary<string, string>> Songs = new Dictionary<string, Dictionary<string, string>>{
        {MemberName.CHRISTINA_AGUILERA.ToString(), ChristinaAguileraSongs},
        {MemberName.LADY_GAGA.ToString(), LadyGagaSongs}
    };

    public static Dictionary<MemberName, MemberType> MemberNameToType= new Dictionary<MemberName, MemberType>{
        {MemberName.CHRISTINA_AGUILERA, MemberType.Singer},
        {MemberName.LADY_GAGA, MemberType.Singer},
        {MemberName.SIMON_COWELL, MemberType.Judge}
    };

    public static string GetRandomSongName(MemberName memberName){
        
        if (! Metadata.Songs.ContainsKey(memberName.ToString())){
            throw new Exception($"Singer {memberName} isn't recognized");
        }
    
        string[] songNames = Metadata.Songs[memberName.ToString()].Keys.ToArray();

        Random random = new Random();
        return songNames[random.Next(0, songNames.Length)];
    }
}