
public class Metadata{
    
    public static Dictionary<string, string> ChristinaAguileraSongs = new Dictionary<string, string>{
        {"Beautiful", "Don't look at me"},
        {"Pero Me Acuerdo de Tí", "Ahora que ya mi vida se encuentra normal"}
    };

    public static Dictionary<string, string> LadyGagaSongs = new Dictionary<string, string>{
        {"Bloody Mary", "Love is just a history that they may prove"},
        {"Always Remember Us This Way", "That Arizona sky burnin' in your eyes"}
    };

    public static Dictionary<string, string> MedonaSongs = new Dictionary<string, string>{
        {"Hung Up", "Time goes by so slowly"},
        {"La Isla Bonita", "Como puede ser verdad"},
    };

    public static Dictionary<string, string> BritneySpearsSongs = new Dictionary<string, string>{
        {"Toxic", "Baby, can't you see I'm calling?"},
        {"Criminal", "He is a hustler, he's no good at all"},
    };

    public static Dictionary<string, string> ShakiraSongs = new Dictionary<string, string>{
        {"Waka Waka", "Tipe, tipe, zangalewa (World Cup! World Cup!)"},
        {"Whenever, Wherever", "Lucky you were born that far away so"},
    };

    public static Dictionary<string, string> AdeleSongs = new Dictionary<string, string>{
        {"I Drink Wine", "How can one become so bounded"},
        {"Skyfall", "This is the end"},
    };

    public static Dictionary<string, string> AvrilLavigneSongs = new Dictionary<string, string>{
        {"Complicated", "Uh huh, life's like this"},
        {"Sk8er Boi", "He was a boy"},
    };

    public static Dictionary<string, string> NickiMinajSongs = new Dictionary<string, string>{
        {"Do We Have A Problem?", "I just told Pee, This really niggas worst nightmare, man"},
        {"Super Bass", "This one is for the boys with the booming system"},
    };

    public static Dictionary<string, string> KeshaSongs = new Dictionary<string, string>{
        {"Backstabber", "Back-back-backstabber"},
        {"We R Who We R", "Hot and dangerous"},
    };

    public static Dictionary<string, string> KellyClarksonSongs = new Dictionary<string, string>{
        {"Because Of You", "I will not make the same mistakes that you did"},
        {"Breakaway", "Da, da, da, da, da, da, da"},
    };

    public static Dictionary<string, string> KatyPerrySongs = new Dictionary<string, string>{
        {"Dark Horse", "Yeah, y'all know what it is"},
        {"California Gurls", "Greetings loved ones"},
    };

    public static Dictionary<string, string> RihanaSongs = new Dictionary<string, string>{
        {"Diamonds", "Shine bright like a diamond"},
        {"Work", "Work, work, work, work, work, work"},
    };

    public static Dictionary<string, string> BeyonceSongs = new Dictionary<string, string>{
        {"CUFF IT", "I feel like fallin' in love (fallin' love)"},
        {"Pretty Hurts", "Ms. Third Ward, your first question"},
    }; 

    public static Dictionary<string, string> JustinBieberSongs = new Dictionary<string, string>{
        {"STAY", "I do the same thing, I told you that I never would"},
        {"Yummy", "Yeah, you got that yummy-yum"},
    }; 

    public static Dictionary<string, Dictionary<string, string>> Songs = new Dictionary<string, Dictionary<string, string>>{
        {MemberName.CHRISTINA_AGUILERA.ToString(), ChristinaAguileraSongs},
        {MemberName.LADY_GAGA.ToString(), LadyGagaSongs},
        {MemberName.MEDONA.ToString(), MedonaSongs},
        {MemberName.BRITNEY_SPEARS.ToString(), BritneySpearsSongs},
        {MemberName.SHAKIRA.ToString(), ShakiraSongs},
        {MemberName.ADELE.ToString(), AdeleSongs},
        {MemberName.AVRIL_LAVIGNE.ToString(), AvrilLavigneSongs},
        {MemberName.NICKI_MINAJ.ToString(), NickiMinajSongs},
        {MemberName.KESHA.ToString(), KeshaSongs},
        {MemberName.KELLY_CLARKSON.ToString(), KellyClarksonSongs},
        {MemberName.KATY_PERRY.ToString(), KatyPerrySongs},
        {MemberName.RIHANA.ToString(), RihanaSongs},
        {MemberName.BEYONCE.ToString(), BeyonceSongs},
        {MemberName.JUSTIN_BIEBER.ToString(), JustinBieberSongs}
    };

    public static Dictionary<MemberName, MemberType> MemberNameToType= new Dictionary<MemberName, MemberType>{
        {MemberName.CHRISTINA_AGUILERA, MemberType.Singer},
        {MemberName.LADY_GAGA, MemberType.Singer},
        {MemberName.MEDONA, MemberType.Singer},
        {MemberName.BRITNEY_SPEARS, MemberType.Singer},
        {MemberName.SHAKIRA, MemberType.Singer},
        {MemberName.ADELE, MemberType.Singer},
        {MemberName.AVRIL_LAVIGNE, MemberType.Singer},
        {MemberName.NICKI_MINAJ, MemberType.Singer},
        {MemberName.KESHA,  MemberType.Singer},
        {MemberName.KELLY_CLARKSON, MemberType.Singer},
        {MemberName.KATY_PERRY, MemberType.Singer},
        {MemberName.RIHANA, MemberType.Singer},
        {MemberName.BEYONCE, MemberType.Singer},
        {MemberName.JUSTIN_BIEBER, MemberType.Singer},

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