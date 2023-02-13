
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOPprojectS
{
    class Program
    {
        static void Main(string[] args)
        {
            Song babyBaby = new Song("baby baby", "BABY BABY BABY OHHHHHH");
            Song lalala = new Song ("la", "LALALALALALALALALALALALALALA");
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
            Judge symonKavel = new Judge("Symon Kavel");
            List<Singer> singersList = new List<Singer>();
            singersList.Add(ladyGaga);
            singersList.Add(christinaAglira);
            singersList.Add(madona);
            singersList.Add(britneySpiers);
            singersList.Add(shakira);
            singersList.Add(addel);
            singersList.Add(abrilLabin);
            singersList.Add(nikiMinaj);
            singersList.Add(kesha);
            singersList.Add(kellyKlarkston);
            singersList.Add(kateyPerry);
            singersList.Add(rhihanna);
            singersList.Add(beyonce);
            singersList.Add(justinBieber);
            //ContestWithJudge contest = new ContestWithJudge(singersList, symonKavel);
            ContestWithAudience contest = new ContestWithAudience(singersList, songs);
            contest.performContest();
            //symonKavel.contest(ladyGaga, christinaAglira);
        }
    }
}
