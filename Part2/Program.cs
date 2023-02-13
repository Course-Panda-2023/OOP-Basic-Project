// See https://aka.ms/new-console-template for more information

/*
 * TODO: Write code for part1.
 * Notice: You need to implement the project structure yourself.
 */

Console.WriteLine(MemberName.CHRISTINA_AGUILERA);
Console.WriteLine(MemberName.LADY_GAGA);
Console.WriteLine(MemberName.SIMON_COWELL);


Judge simon = new Judge(MemberName.SIMON_COWELL);
Singer[] singers = new Singer[]{
    new Singer(MemberName.CHRISTINA_AGUILERA),
    new Singer(MemberName.LADY_GAGA),
    new Singer(MemberName.MEDONA),
    new Singer(MemberName.BRITNEY_SPEARS),
    new Singer(MemberName.SHAKIRA),
    new Singer(MemberName.ADELE),
    new Singer(MemberName.AVRIL_LAVIGNE),
    new Singer(MemberName.NICKI_MINAJ),
    new Singer(MemberName.KESHA),
    new Singer(MemberName.KELLY_CLARKSON),
    new Singer(MemberName.KATY_PERRY),
    new Singer(MemberName.RIHANA),
    new Singer(MemberName.BEYONCE),
    new Singer(MemberName.JUSTIN_BIEBER)
};

simon.StartCompetition(singers);