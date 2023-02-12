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


Singer[] singers = new Singer[] {
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


Judge simon = new Judge(MemberName.SIMON_COWELL);

simon.StartCompetition(singers, crowdMembers);

