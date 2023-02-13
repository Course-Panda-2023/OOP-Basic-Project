﻿namespace MySingingContest
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Main4();
        }
        static void Main4()
        {
            string[] backstreetBoysMembers = { "dude1", "dude2", "dude3" };
            Band backstreetBoys = new Band("backstreet Boys", backstreetBoysMembers);
            string[] westLifeMembers = { "dode1", "dode2", "dode3" };
            Band westLife = new Band("West Life", westLifeMembers);
            string[] nSyncMembers = { "dide1", "dide2", "dide3" };
            Band nSync = new Band("N Sync", nSyncMembers);
            string[] highFiveMembers = { "dade1", "dade2", "dade3" };
            Band highFive = new Band("High Five", highFiveMembers);
            string[] simplePlanMembers = { "dede1", "dede2", "dede3" };
            Band simplePlan = new Band("Simple Plan", simplePlanMembers);
            string[] jonasBrothersMembers = { "dade1", "dade2", "dade3" };
            Band jonasBrothers = new Band("Jonas Brothers", jonasBrothersMembers);
            string[] theJackson5Members = { "dyde1", "dyde2", "dyde3" };
            Band theJackson5 = new Band("The Jackson 5", theJackson5Members);

            Singer gaga = new Singer("lady gaga");
            Singer christina = new Singer("Christina");
            Singer madonna = new Singer("maddona");

            Participant[] participants = { gaga, christina, madonna, backstreetBoys, westLife, nSync, highFive, simplePlan, theJackson5 };

            Song song1 = new Song("song1", "Ooh ooh song1");
            Song song2 = new Song("song2", "Ooh ooh song2");
            Song song3 = new Song("song3", "Ooh ooh song3");
            Song[] songs = { song1, song2, song3 };

            Audience audience = new Audience();
            foreach (Participant participant in participants)
            {
                participant.AddSong(participant.ChooseSong(songs));
                participant.SingASong();
            }
            Participant winner = audience.Voting(participants);
            Console.WriteLine($"The winner is {winner.GetName()}!");
            Console.ReadLine();

        }
        static void Main3() 
        {
            Song song1 = new Song("song1", "Ooh ooh song1");
            Song song2 = new Song("song2", "Ooh ooh song2");
            Song song3 = new Song("song3", "Ooh ooh song3");
            Song[] songs = {song1, song2, song3};

            Singer gaga = new Singer("lady gaga");
            Singer christina = new Singer("Christina");
            Singer madonna = new Singer("maddona");
            Singer britney = new Singer("britny");
            Singer shakira = new Singer("shakira");
            Singer adel = new Singer("adel");
            Singer abril = new Singer("abril");
            Singer nicki = new Singer("nicki");
            Singer kesha = new Singer("kesha");
            Singer clarkson = new Singer("clarkson");
            Singer katy = new Singer("katy");
            Singer riahnna = new Singer("riahnna");
            Singer bionce = new Singer("bionce");
            Singer justin = new Singer("justin");
            Singer[] singers = { gaga, christina, madonna, britney, shakira, adel, abril, nicki, kesha, clarkson, katy, riahnna, bionce, justin };

            Audience audience = new Audience();
            foreach (Singer singer in singers) 
            {
                singer.AddSong(singer.ChooseSong(songs));
                singer.SingASong();
            }
            Participant winner = audience.Voting(singers);
            Console.WriteLine($"The winner is {winner.GetName()}!");
            Console.ReadLine();
        }
        static void Main2()
        {
            Song song1 = new Song("song1", "Ooh ooh song1");
            Song song2 = new Song("song2", "Ooh ooh song2");
            Song song3 = new Song("song3", "Ooh ooh song3");
            Song song4 = new Song("song4", "Ooh ooh song4");
            Song song5 = new Song("song5", "Ooh ooh song5");
            Song song6 = new Song("song6", "Ooh ooh song6");
            Song song7 = new Song("song7", "Ooh ooh song7");
            Song song8 = new Song("song8", "Ooh ooh song8");
            Song song9 = new Song("song9", "Ooh ooh song9");
            Song song10 = new Song("song10", "Ooh ooh song10");
            Song song11 = new Song("song11", "Ooh ooh song11");
            Song song12 = new Song("song12", "Ooh ooh song12");
            Song song13 = new Song("song13", "Ooh ooh song13");
            Song song14 = new Song("song14", "Ooh ooh song14");

            Singer gaga = new Singer("lady gaga", song1);
            Singer christina = new Singer("Christina", song2);
            Singer madonna  = new Singer("maddona", song3);
            Singer britney = new Singer("britny", song4);
            Singer shakira = new Singer("shakira", song5);
            Singer adel = new Singer("adel", song6);
            Singer abril = new Singer("abril", song7);
            Singer nicki = new Singer("nicki", song8);
            Singer kesha = new Singer("kesha", song9);
            Singer clarkson = new Singer("clarkson", song10);
            Singer katy = new Singer("katy", song11);
            Singer riahnna = new Singer("riahnna", song12);
            Singer bionce = new Singer("bionce", song13);
            Singer justin = new Singer("justin", song14);

            Singer[] singers = { gaga, christina, madonna, britney, shakira, adel, abril, nicki, kesha, clarkson, katy, riahnna, bionce, justin };
            Judge simon = new Judge("Simon");
            simon.Tournament(singers);
            Console.ReadLine();
        }
        static void Main1()
        {
            Song badRomance = new Song("bad romance", "ra ra ooh la la");
            Singer gaga = new Singer("lady gaga", badRomance);
            Song hurt = new Song("hurt", "Ooh, ooh");
            Singer christina = new Singer("Christina", hurt);
            Judge simon = new Judge("Simon");
            simon.Duel(christina, gaga);
            Console.ReadLine();
        }
    }
}