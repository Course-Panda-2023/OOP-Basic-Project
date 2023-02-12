﻿Judge simonCowell = new Judge("Simon Cowell");
Singer ladyGaga = new Singer("Lady Gaga", "Pop", Singer.VocalRange.Alt);
Singer christinaAguilera = new Singer("Christina Aguilera", "Pop", Singer.VocalRange.Soprano);
Singer madonna = new Singer("Madonna", "Pop", Singer.VocalRange.Soprano);
Singer kesha = new Singer("Ke$ha", "Pop", Singer.VocalRange.Soprano);
Singer britney = new Singer("britney", "Pop", Singer.VocalRange.Soprano);
Singer kellyClarkson = new Singer("Kelly Clarkson", "Pop", Singer.VocalRange.Soprano);
Singer shakira = new Singer("shakira", "Pop", Singer.VocalRange.Soprano);
Singer katyPerry = new Singer("Katy Perry", "Pop", Singer.VocalRange.Soprano);
Singer adele = new Singer("adele", "Pop", Singer.VocalRange.Soprano);
Singer rihanna = new Singer("rihanna", "Pop", Singer.VocalRange.Soprano);
Singer avrileLavigne = new Singer("Avril Lavigne", "Pop", Singer.VocalRange.Soprano);
Singer beyonce = new Singer("beyonce", "Pop", Singer.VocalRange.Soprano);
Singer nickiMinaj = new Singer("Nicki Minaj", "Pop", Singer.VocalRange.Soprano);
Singer justinBieber = new Singer("Justin Bieber", "Pop", Singer.VocalRange.Soprano);

Song gaga1 = new Song("Shallow", "Tell me something, girl\r\nAre you happy in this modern world?\r\nOr do you need more?\r\nIs there something else you're searchin' for?\r\nI'm falling\r\nIn all the good times, I find myself longin' for change\r\nAnd in the bad times, I fear myself\r\nTell me something, boy\r\nAren't you tired trying to fill that void?\r\nOr do you need more?\r\nAin't it hard keeping it so hardcore?\r\nI'm falling\r\nIn all the good times, I find myself longing for change\r\nAnd in the bad times, I fear myself\r\nI'm off the deep end, watch as I dive in\r\nI'll never meet the ground\r\nCrash through the surface, where they can't hurt us\r\nWe're far from the shallow now\r\nIn the sha-ha, sha-ha-llow\r\nIn the sha-ha-sha-la-la-la-llow\r\nIn the sha-ha, sha-ha-llow\r\nWe're far from the shallow now\r\nOh, ha-ah-ah\r\nAh, ha-ah-ah, oh, ah\r\nHa-ah-ah-ah\r\nI'm off the deep end, watch as I dive in\r\nI'll never meet the ground\r\nCrash through the surface, where they can't hurt us\r\nWe're far from the shallow now\r\nIn the sha-ha, sha-ha-llow\r\nIn the sha-ha-sha-la-la-la-llow\r\nIn the sha-ha, sha-ha-llow\r\nWe're far from the shallow now");
Song christina1 = new Song("Beautiful", "Don't look at me\r\nEvery day is so wonderful\r\nThen suddenly it's hard to breathe\r\nNow and then I get insecure\r\nFrom all the pain\r\nI'm so ashamed\r\nI am beautiful no matter what they say\r\nWords can't bring me down\r\nI am beautiful in every single way\r\nYes, words can't bring me down, oh no\r\nSo don't you bring me down today\r\nTo all your friends you're delirious\r\nSo consumed in all your doom\r\nTrying hard to fill the emptiness\r\nThe pieces gone, left the puzzle undone\r\nIs that the way it is?\r\nYou are beautiful no matter what they say\r\nWords can't bring you down, oh no\r\nYou are beautiful in every single way\r\nYes, words can't bring you down, oh no\r\nSo don't you bring me down today\r\nNo matter what we do\r\n(No matter what we do)\r\nNo matter what we say\r\n(No matter what we say)\r\nWe're the song inside the tune (Yeah)\r\nFull of beautiful mistakes\r\nAnd everywhere we go\r\n(And everywhere we go)\r\nThe sun will always shine\r\n(The sun will always, always shine)\r\nAnd tomorrow we might wake on the other side\r\n'Cause we are beautiful no matter what they say\r\nYes, words won't bring us down, no, no\r\nWe are beautiful in every single way\r\nYes, words can't bring us down, oh, no\r\nSo don't you bring me down today\r\nOoh-oh-oh, yeah\r\nDon't you bring me down today\r\nYeah, ooh\r\nDon't you bring me down\r\nOoh, today");
Song song3 = new Song("CAMPFIRE SONG song", " C A M P F I R E S O N G song");

Song[] songs = {gaga1, christina1, song3};
ladyGaga.AddList(songs);
christinaAguilera.AddList(songs);
madonna.AddList(songs);
kesha.AddList(songs);
britney.AddList(songs);
kellyClarkson.AddList(songs);
shakira.AddList(songs);
katyPerry.AddList(songs);
adele.AddList(songs);
rihanna.AddList(songs);
avrileLavigne.AddList(songs);
beyonce.AddList(songs);
nickiMinaj.AddList(songs);
justinBieber.AddList(songs);
Singer[] list = { ladyGaga, christinaAguilera, madonna, kesha, britney, kellyClarkson, shakira, katyPerry, adele, rihanna, avrileLavigne, beyonce, nickiMinaj, justinBieber };

Judge.AudienceCompetition(list);
Console.ReadLine();
