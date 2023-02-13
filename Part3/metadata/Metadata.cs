
public class Metadata{
    
    public static Dictionary<string, string> Songs = new Dictionary<string, string>{
        {"Beautiful", "Don't look at me"},
        {"Pero Me Acuerdo de Tí", "Ahora que ya mi vida se encuentra normal"},
        {"Bloody Mary", "Love is just a history that they may prove"}
    };

    public static Dictionary<MemberName, MemberType> MemberNameToType = new Dictionary<MemberName, MemberType>{
        {MemberName.CHRISTINA_AGUILERA, MemberType.Singer},
        {MemberName.LADY_GAGA, MemberType.Singer},
        {MemberName.MEDONA, MemberType.Singer},
        {MemberName.BRITNEY_SPEARS, MemberType.Singer},
        {MemberName.SHAKIRA, MemberType.Singer},
        {MemberName.ADELE, MemberType.Singer},
        {MemberName.AVRIL_LAVIGNE, MemberType.Singer},
        {MemberName.NICKI_MINAJ, MemberType.Singer},
        {MemberName.KESHA, MemberType.Singer},
        {MemberName.KELLY_CLARKSON, MemberType.Singer},
        {MemberName.KATY_PERRY, MemberType.Singer},
        {MemberName.RIHANA, MemberType.Singer},
        {MemberName.BEYONCE, MemberType.Singer},
        {MemberName.JUSTIN_BIEBER, MemberType.Singer},

        {MemberName.SIMON_COWELL, MemberType.Judge}
    };

    public static string GetRandomSongName(MemberName memberName){
        string[] songNames = Songs.Keys.ToArray();

        Random random = new Random();
        return songNames[random.Next(0, songNames.Length)];
    }
}