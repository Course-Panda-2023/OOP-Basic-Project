﻿// See https://aka.ms/new-console-template for more information


using System.Runtime;

string song1 = "ra ra rama ma";
string[] array1 = { song1, "p-p-p-pocker face, p-p-pocker face", "in the sha-ha-sha-ha-hallow" };
Singer ladyGaga = new Singer("Lady Gaga", array1);
string song2 = "seems like it was yesterday when i saw your face";
string[] array2 = { song2, "you are beatuiful", "i dont know any of her songs" };
Singer christina = new Singer("Christina Aguilera", array2);
Judge simonCowell = new Judge("Simon Cowell");
string song3 = "super frealy girl";
string[] array3 = { song3, "starships were meant to fly", "the light is coming" };
Singer nickiminaj = new Singer("Nicki Minaj", array3);
string song4 = "na na na na na b*tch im madonna";
string[] array4 = { song4, "just like a prayer", "madonna song" };
Singer madonna = new Singer("Madonna", array4);
string song5 = "oops i did it again";
string[] array5 = { song5, "toxic", "womanizer" };
Singer britenyspears = new Singer("Briteny Spears", array5);
string song6 = "waka waka eh eh";
string[] array6 = { song6, "hips dont like", "loca loca loca" };
Singer shakira = new Singer("Shakira", song6);
string song7 = "never mind ill find someone like you";
string[] array7 = { song7, "hello", "fire to the rain" };
Singer adele = new Singer("Adele", array7);
string song8 = "tik tok on the clock";
string[] array8 = { song8, "cannibal", "kesha song" };
Singer kesha = new Singer("Ke$ha", array8);
string song9 = "just me myself and i";
string[] array9 = { song9, "kelly song 2", "kelly song 3" };
Singer kellyclarkson = new Singer("Kelly Clarkson", array9);
string song10 = "and youre gonna hear me roarrrr";
string[] array10 = { song10, "teenage dream", "the one that got away" };
Singer katyperry = new Singer("Katy Perry", array10);
string song11 = "must be love on the brain";
string[] array11 = { song11, "deperado", "work work work work work work" };
Singer rihanna = new Singer("Rihanna", array11);
string song12 = "WHO RUNS THE WORLD? GIRLS";
string[] array12 = { song12, "all the single ladies all the single ladies", "lemonade" };
Singer beyonce = new Singer("beyonce", array12);
string song13 = "baby baby baby oh";
string[] array13 = { song13, "boyfriend", "intentions" };
Singer justinbieber = new Singer("Justin Bieber", array13);
string song14 = "why'd ypu have to go and make things so complicated";
string[] array14 = { song14, "what the hell", "smile" };
Singer avrillavine = new Singer("Avril Lavigne", array14);

Singer one = new Singer("first");
Singer two = new Singer("second");
Singer three = new Singer("third");

Singer[] singersInABand = { one, two, three };
Band onedirection = new Band(singersInABand,"thats what makes you beautiful","one direction");

Member[] members = { ladyGaga, christina, nickiminaj, onedirection };

Singer[] singers = { ladyGaga, christina, nickiminaj, madonna, britenyspears, shakira, adele, nickiminaj, kesha, kellyclarkson, katyperry, rihanna, beyonce, justinbieber, avrillavine };
simonCowell.CrowdsChoice(561,members);
Console.ReadLine();
