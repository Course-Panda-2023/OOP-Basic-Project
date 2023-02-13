using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//


namespace OOPprojectS
{
    class Program
    {
        static void Main(string[] args)
        {
            Song babyBaby = new Song("baby baby", "BABY BABY BABY OHHHHHH");
            Song lalala = new Song("la", "LALALALALALALALALALALALALALA");
            Song dontStopMeNow = new Song("dont stop me now", "dont stop me now, cause im having a good time, having a good time,...");
            List<Song> songs = new List<Song>();
            songs.Add(babyBaby);
            songs.Add(lalala);
            songs.Add(dontStopMeNow);
            Singer ladyGaga = new Singer("Lady Gaga", songs);
            Singer christinaAglira = new Singer("Christina Algira", songs);
            Singer madona = new Singer("Madona", songs);
            Singer britneySpiers = new Singer("Britney Spiers", songs);
            Singer shakira = new Singer("Shakira", songs);
            Singer addel = new Singer("Addel", songs);
            Singer abrilLabin = new Singer("Abril Labin", songs);
            Singer nikiMinaj = new Singer("Niki Minaj", songs);
            Singer kesha = new Singer("Kesha", songs);
            Singer kellyKlarkston = new Singer("Kelly Klarkston", songs);
            Singer kateyPerry = new Singer("Katey Perry", songs);
            Singer rhihanna = new Singer("Rhihanna", songs);
            Singer beyonce = new Singer("Beyonce", songs);
            Singer justinBieber = new Singer("Justin Bieber", songs);

            Band backStreetBoys = new Band("Back Street Boys", songs);
            Band westLife = new Band("West Life", songs);
            Band nSync = new Band("N'Sync", songs);
            Band highFive = new Band("High Five", songs);
            Band simplePlan = new Band("Simple Plan", songs);
            Band jonasBrothers = new Band("Jonas Brothers", songs);
            Band theJackson5 = new Band("The Jackson 5", songs);
            //Band maroon5 = new Band("Maroon 5", songs);
            //Band blink182 = new Band("Blink 182", songs);
            //Band greenDay = new Band("Green Day", songs);
            //Band thirtySecsToMars = new Band("30 Seconds To Mars", songs);
            //Band nickelBack = new Band("Nickel Back", songs);
            //Band sum41 = new Band("Sum 41", songs);
            //Band lmfao = new Band("LMFAO", songs);

            

            Judge symonKavel = new Judge("Symon Kavel");
            List<Performer> performersList = new List<Performer>();
            performersList.Add(ladyGaga);
            performersList.Add(christinaAglira);
            performersList.Add(madona);
            performersList.Add(britneySpiers);
            performersList.Add(shakira);
            performersList.Add(addel);
            performersList.Add(abrilLabin);
            performersList.Add(nikiMinaj);
            performersList.Add(kesha);
            performersList.Add(kellyKlarkston);
            performersList.Add(kateyPerry);
            performersList.Add(rhihanna);
            performersList.Add(beyonce);
            performersList.Add(justinBieber);
            performersList.Add(backStreetBoys);
            performersList.Add(westLife);
            performersList.Add(nSync);
            performersList.Add(highFive);
            performersList.Add(simplePlan);
            performersList.Add(jonasBrothers);
            performersList.Add(theJackson5);
            //performersList.Add(maroon5);
            //performersList.Add(blink182);
            //performersList.Add(greenDay);
            //performersList.Add(thirtySecsToMars);
            //performersList.Add(nickelBack);
            //performersList.Add(sum41);
            //performersList.Add(lmfao);

            //ContestWithJudge contest = new ContestWithJudge(singersList, symonKavel);
            ContestWithAudience contest = new ContestWithAudience(performersList, songs);
            contest.performContest();
            //symonKavel.contest(ladyGaga, christinaAglira);
        }
    }
}