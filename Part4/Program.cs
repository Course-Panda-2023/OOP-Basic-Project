// See https://aka.ms/new-console-template for more information

/*
 * TODO: Copy all of your code from part3 and continue here.
 */


// See https://aka.ms/new-console-template for more information

/*
 * TODO: Copy all of your code from part2 and continue here.
 */


 int MAX_CROWD_MEMBERS = 1000;


string[] crowdMembersNames = new string[] {
    "Asaf",
    "Ohad",
    "Noam",
    "Adi",
    "Naama",
    "Yael"
};


Random random = new Random();
int numCrowdMembers = random.Next(1, MAX_CROWD_MEMBERS + 1);


CrowdMember[] crowdMembers = new CrowdMember[numCrowdMembers];
for (int i=0; i < numCrowdMembers; i++){
    crowdMembers[i] = new CrowdMember(crowdMembersNames[random.Next(0, crowdMembersNames.Length)]);
}


Competitor[] singers = new Competitor[] {
    new SingleSinger(MemberName.CHRISTINA_AGUILERA),
    new SingleSinger(MemberName.LADY_GAGA),
    new SingleSinger(MemberName.MEDONA),
    new SingleSinger(MemberName.BRITNEY_SPEARS),
    new SingleSinger(MemberName.SHAKIRA),
    new SingleSinger(MemberName.ADELE),
    new SingleSinger(MemberName.AVRIL_LAVIGNE),
    new SingleSinger(MemberName.NICKI_MINAJ),
    new SingleSinger(MemberName.KESHA),
    new SingleSinger(MemberName.KELLY_CLARKSON),
    new SingleSinger(MemberName.KATY_PERRY),
    new SingleSinger(MemberName.RIHANA),
    new SingleSinger(MemberName.BEYONCE),
    new SingleSinger(MemberName.JUSTIN_BIEBER),

    new Band(MemberName.BACKSTREET_BOYS, new string[]{"Nick Carter", "KEVIN RICHARDSON"}),
    new Band(MemberName.WESTLIFE, new string[]{"Nicky Byrne", "Kian Egan", "Mark Feehily", "Shane Filan"}),
    new Band(MemberName.NSYNC, new string[]{"Justin Timberlake", "JC Chasez"}),
    new Band(MemberName.HIGH_FIVE, new string[]{"Marcus Sanders", "Shannon Gill"}),
    new Band(MemberName.SIMPLE_PLAN, new string[]{"Pierre Bouvier", "Chuck Comeau"}),
    new Band(MemberName.JONAS_BROTHERS, new string[]{"Kevin Jonas", "Joe Jonas", "Nick Jonas"}),
    new Band(MemberName.THE_JACKSON_5, new string[]{"Jackie Jackson", "Tito Jackson", "Marlon Jackson"})
};


Judge simon = new Judge(MemberName.SIMON_COWELL);

simon.StartCompetition(singers, crowdMembers);

