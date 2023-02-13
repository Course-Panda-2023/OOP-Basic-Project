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

Musician[] exampleBandMembers = new Musician[]{
    new Singer("Anna"),
    new Drummer("Shira"),
    new Guitarist("Eli")
};


Competitor[] singers = new Competitor[] {
    new Singer("Christina Aguilera"),
    new Singer("Lady Gaga"),
    new Singer("Medona"),
    new Singer("Britney Spears"),
    new Singer("Shakira"),
    new Singer("Adele"),
    new Singer("Avril Lavigne"),
    new Singer("Nicki Minaj"),
    new Singer("Kesha"),
    new Singer("Kelly Clarkson"),
    new Singer("Katy Perry"),
    new Singer("Rihana"),
    new Singer("Beyonce"),
    new Singer("Justin Bieber"),

    new Band("Backstreet_boys", exampleBandMembers),
    new Band("Westlife", exampleBandMembers),
    new Band("N’ Sync", exampleBandMembers),
    new Band("High Five", exampleBandMembers),
    new Band("Simple Plan", exampleBandMembers),
    new Band("Jonas Brothers",  exampleBandMembers),
    new Band("The Jackson 5", exampleBandMembers), 
    new Band("Maroon 5", exampleBandMembers ), 
    new Band("Blink 182", exampleBandMembers), 
    new Band("Green Day", exampleBandMembers), 
    new Band("30 Seconds to Mars", exampleBandMembers), 
    new Band("Nickelback", exampleBandMembers), 
    new Band("Sum41", exampleBandMembers), 
    new Band("LMFAO", exampleBandMembers), 
};

Judge simon = new Judge("Simon Cowell");

simon.StartCompetition(singers, crowdMembers);

