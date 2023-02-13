
public class Metadata{
    
    public static Dictionary<string, string> Songs = new Dictionary<string, string>{
        {"Beautiful", "Don't look at me"},
        {"Pero Me Acuerdo de Tí", "Ahora que ya mi vida se encuentra normal"},
        {"Bloody Mary", "Love is just a history that they may prove"}
    };

    public static Dictionary<MemberName, MemberType> MemberNameToType = new Dictionary<MemberName, MemberType>{
        // single singers
        {MemberName.CHRISTINA_AGUILERA, MemberType.Competitor},
        {MemberName.LADY_GAGA, MemberType.Competitor},
        {MemberName.MEDONA, MemberType.Competitor},
        {MemberName.BRITNEY_SPEARS, MemberType.Competitor},
        {MemberName.SHAKIRA, MemberType.Competitor},
        {MemberName.ADELE, MemberType.Competitor},
        {MemberName.AVRIL_LAVIGNE, MemberType.Competitor},
        {MemberName.NICKI_MINAJ, MemberType.Competitor},
        {MemberName.KESHA, MemberType.Competitor},
        {MemberName.KELLY_CLARKSON, MemberType.Competitor},
        {MemberName.KATY_PERRY, MemberType.Competitor},
        {MemberName.RIHANA, MemberType.Competitor},
        {MemberName.BEYONCE, MemberType.Competitor},
        {MemberName.JUSTIN_BIEBER, MemberType.Competitor},

        // bands

        {MemberName.BACKSTREET_BOYS, MemberType.Competitor},
        {MemberName.WESTLIFE, MemberType.Competitor},
        {MemberName.NSYNC, MemberType.Competitor},
        {MemberName.HIGH_FIVE, MemberType.Competitor},
        {MemberName.SIMPLE_PLAN, MemberType.Competitor},
        {MemberName.JONAS_BROTHERS, MemberType.Competitor},
        {MemberName.THE_JACKSON_5, MemberType.Competitor},

        //jusges

        {MemberName.SIMON_COWELL, MemberType.Judge}
    };

    public static string GetRandomSongName(MemberName memberName){
        string[] songNames = Songs.Keys.ToArray();

        Random random = new Random();
        return songNames[random.Next(0, songNames.Length)];
    }
}