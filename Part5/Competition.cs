using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopFinal
{
    internal class Competition
    {
        private Judge competitionJudge;
        private List<ParticipantInCompetition> members=new List<ParticipantInCompetition>();
        private int audience;
        private List<Song> songs=new List<Song>();  

        public Competition(List<ParticipantInCompetition> members, List<Song> songs,Judge judge,int audience) { 
            this.competitionJudge = judge;
            this.members = members;
            this.audience = audience; 
            this.songs = songs;
         
        }


        public void compete()
        {
            Random rnd =new Random();
            List<ParticipantInCompetition> memberToChoose;
            int max = 0;
            Dictionary<ParticipantInCompetition, int> points = new Dictionary<ParticipantInCompetition, int>();
            Console.WriteLine("Welcome to our song contest");
            foreach (ParticipantInCompetition member in members)
            {
                points.Add(member, 0);
            }
            foreach (ParticipantInCompetition member in members) {
                member.Sing(songs[rnd.Next(songs.Count)]);
            }
            Console.WriteLine("////////////////////////////////////\nNow vote to your favorite performance");
            do
            {
                for(int i = 0; i < audience; i++)
                {
                    memberToChoose = points.Keys.ToList();
                    points[memberToChoose[rnd.Next(memberToChoose.Count)]] += 1;
                }
                points = Helper.GetKeyFromValue(points.Values.ToList().Max(), points);
                Console.WriteLine("//////////////////////////////");


            } while (points.Count > 1);
            
            Console.WriteLine($"The winner is {points.Keys.ToList()[0].getName()}");
        }

        //public void compete()
        //{
        //    int len = singers.Count;
        //    List<Singer> CopyList;
        //    Singer singer1,singer2,loser;
        //    Random rnd = new Random();  
        //    Console.WriteLine("Welcome to our song contest");

        //    while(singers.Count > 1) {
        //        PrintSingers();
        //        CopyList = new List<Singer>(singers);
        //        while (CopyList.Count > 1) {
        //            singer1 = CopyList[rnd.Next(CopyList.Count)];
        //            CopyList.Remove(singer1);
        //            singer2 = CopyList[rnd.Next(CopyList.Count)];
        //            loser=Competition1v1(singer1, singer2);
        //            singers.Remove(loser);
        //            CopyList.Remove(singer1);
        //            CopyList.Remove(singer2);


        //            Console.WriteLine("\n///////////////////////////\n");
        //        }
        //        Console.WriteLine("\n\nround is over!!!!!!!\n\n");
        //        //Console.ReadLine();

        //    }

        //    Console.WriteLine($"The winner is {singers[0].Name}");

        //}
        public void PrintSingers()
        {
            Console.WriteLine($"\nour singers are:");
            foreach (ParticipantInCompetition p in members)
            {
                Console.Write($"{p.getName()} ,");
            }
            Console.WriteLine("\n");    
            
        }
        //public Singer Competition1v1(Singer singer1,Singer singer2)
        //{
        //    Singer loser;
        //    Console.WriteLine($"Now we'll see {singer1.Name} vs {singer2.Name}");
        //    Console.WriteLine($"first performance is {singer1.Name}");
        //    singers[0].Sing("la la la");
        //    Console.WriteLine($"Now {singer2.Name} will sing");
        //    singers[1].Sing("la la la");
        //    Console.WriteLine($"lets hear what our judge {competitionJudge.Name} has to say");
        //    loser = competitionJudge.ToJudge(singer1, singer2);


        //    return loser;


        //}
    }
}
