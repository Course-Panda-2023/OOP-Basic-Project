using Part1;

Judge simon = new Judge(1234512, "Simon Kawel", 1.83, 35, true);
Contestent gaga = new Contestent(121212, "Lady Gaga", 1.72, true, false);
Contestent christina = new Contestent(132332, "Christina  Aguilera ", 1.68, false, true);

Song song1 = new Song("SpongeBob", "Who lives in a pineapple under the sea???");
Song song2 = new Song("Mundial WakaWaka", "Tsamina mina, eh, eh\r\nWaka waka, eh, eh\r\nTsamina mina zangalewa, anawa-a-a\r\n");

christina.Sing(song1);
gaga.Sing(song2);
simon.ChooseWinner(christina, gaga);