// See https://aka.ms/new-console-template for more information
using OopFinal;

Console.WriteLine("Hello, World!");
Judge judge = new Judge("Simon Cowell");
Singer singer1 = new Singer("Lady Gaga");
Singer singer2 = new Singer("Christina Aguilera");
Singer singer3 = new Singer("Britney Spears");
Singer singer4 = new Singer("Madonna");
Singer singer5 = new Singer("Shakira");
Singer singer6 = new Singer("Adel");
Singer singer7 = new Singer("Avril Lavigne");
Singer singer8 = new Singer("Nicki Minaj");
Singer singer9 = new Singer("Ke$ha");
Singer singer10 = new Singer("Kelly Clarkson");
Singer singer11 = new Singer("Katy Perry");
Singer singer12 = new Singer("Rihanna");
Singer singer13 = new Singer("Beyonce");
Singer singer14 = new Singer("Justin bieber");

List<Singer> SingersInBand= new List<Singer>();
List<Guitarists> GuitaristsInBand = new List<Guitarists>();
List<Drummer> DrummersInBand = new List<Drummer>();
for (int i = 0; i < 3; i++) { SingersInBand.Add(new Singer("Backstreet_boys_" + i)); }
GuitaristsInBand.Add(new Guitarists("G-Backstreet_boys"));
DrummersInBand.Add(new Drummer("D-Backstreet_boys"));

Band BackstreetBoys=new Band("Backstreet boys",SingersInBand,GuitaristsInBand,DrummersInBand);

SingersInBand = new List<Singer>();
GuitaristsInBand = new List<Guitarists>();
DrummersInBand = new List<Drummer>();

for (int i = 0; i < 2; i++) { SingersInBand.Add(new Singer("Westlife_" + i)); }
GuitaristsInBand.Add(new Guitarists("G-Westlife"));

Band Westlife = new Band("Westlife", SingersInBand,GuitaristsInBand,DrummersInBand);


//BandMembers = new List<Singer>();

//for (int i = 0; i < 4; i++) { BandMembers.Add(new Singer("N'Sync" + i)); }
//Band NSync = new Band("N'Sync", BandMembers);
//BandMembers = new List<Singer>();








List<ParticipantInCompetition> list = new List<ParticipantInCompetition>() {singer1, singer2, singer3, singer4, singer5, singer6, singer7, singer8, singer9, singer10, singer11, singer12,singer13,singer14, BackstreetBoys , Westlife};
Song s1 =new Song("song1","Shishhhhh");
Song s2 = new Song("song2", "Damnnnn!!!!");
Song s3 = new Song("song3", "LOL");
List<Song> songs = new List<Song>() { s1, s2, s3 };


Competition myCompetition = new Competition(list,songs,judge,100);
myCompetition.compete();
