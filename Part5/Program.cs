using Part5;
using System;
using System.Numerics;
using System.Runtime.InteropServices;


List<Song> songs = new List<Song>();

Song song1 = new Song("Talking To The Moon", "I know you're somewhere out there\r\nSomewhere far away\r\nI want you back," +
        " I want you back\n...\nI know you're somewhere out there\r\nSomewhere far away");
Song song2 = new Song ("Royals", "I've never seen a diamond in the flesh\r\nI cut my teeth on wedding rings in the movies\r\n" +
        "And I'm not proud of my address\r\nIn a torn up town, no postcode envy\n...\nAnd baby, I'll rule (I'll rule," +
        " I'll rule, I'll rule)\r\nLet me live that fantasy");
Song song3 = new Song("Demons", "When the days are cold\r\nAnd the cards all fold\r\nAnd the saints we see are all made of " +
        "gold\r\nWhen your dreams all fail\r\nAnd the ones we hail\r\nAre the worst of all, and the blood's run stale" +
        "\n...\nIt's where my demons hide\r\nIt's where my demons hide");

songs.Add(song1);
songs.Add(song2);
songs.Add(song3);


Singer christinaAguilera = new Singer("Christina Aguilera");
Singer ladyGaga = new Singer("Lady Gaga");
Singer madonna = new Singer("Madonna");
Singer kesha = new Singer("Kesha");
Singer kellyClarkson = new Singer("Kelly Clarkson");
Singer shakira = new Singer("Shakira");
Singer katyPerry = new Singer("Katy Perry");
Singer adele = new Singer("Adele");
Singer rihanna = new Singer("Rihanna");
Singer britneySpears = new Singer("Britney Spears");
Singer avrilLavigne = new Singer("Avril Lavigne");
Singer beyonce = new Singer("Beyoncé");
Singer nickiMinaj = new Singer("Nicki Minaj");
Guitarist justinBieber = new Guitarist("Justin Bieber");

Guitarist nickCarter = new Guitarist("Nick Carter");
Singer howieDorough = new Singer("Howie Dorough");
Singer AJMcLean = new Singer("AJ McLean");
Drummer brianLittrell = new Drummer("Brian Littrell");
Guitarist kevinRichardson = new Guitarist("Kevin Richardson");

Singer shaneFilan = new Singer("Shane Filan");
Drummer markFeehily = new Drummer("Mark Feehily");
Guitarist kianEgan = new Guitarist("Kian Egan");
Singer nickyByrne = new Singer("Nicky Byrne");

Singer justinTimberlake = new Singer("Justin Timberlake");
Guitarist JCChasez = new Guitarist("JC Chasez");
Guitarist joeyFatone = new Guitarist("Joey Fatone");
Drummer chrisKirkpatrick = new Drummer("Chris Kirkpatrick");
Singer lanceBass = new Singer("Lance Bass");

Band maroon5 = new Band("Maroon 5", justinTimberlake, JCChasez, joeyFatone, chrisKirkpatrick, lanceBass);

Band blink182 = new Band("Blink 182", brianLittrell, chrisKirkpatrick, nickyByrne, rihanna);

Band greenDay = new Band("Green Day", kesha, justinTimberlake, lanceBass);

Band secondsToMars = new Band("30 Seconds to Mars", avrilLavigne, beyonce, nickiMinaj, justinBieber);

Band nickelback = new Band("Nickelback", nickCarter, howieDorough, kianEgan, nickyByrne);
Band sum41 = new Band("Sum41", nickCarter, howieDorough, AJMcLean, brianLittrell, kevinRichardson);
Band LMFAO = new Band("LMFAO", shaneFilan, markFeehily, kianEgan, nickyByrne);


Judge simonCowell = new Judge("Simon Cowell");

Contest theVoice = new Contest(simonCowell, songs, 100, christinaAguilera, ladyGaga, madonna, kesha, britneySpears,
    kellyClarkson, shakira, katyPerry, adele, rihanna, avrilLavigne, beyonce, nickiMinaj, justinBieber, maroon5, blink182,
    greenDay, secondsToMars, nickelback, sum41, LMFAO, JCChasez, chrisKirkpatrick);

theVoice.Competition();