﻿// See https://aka.ms/new-console-template for more information

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
    new Singer(MemberName.LADY_GAGA)
};

simon.StartCompetition(singers);