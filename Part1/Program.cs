// See https://aka.ms/new-console-template for more information

/*
 * TODO: Write code for part1.
 * Notice: You need to implement the project structure yourself.
 */
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
            List<Song> songs = new List<Song>();
            songs.Add(babyBaby);
            Singer ladyGaga = new Singer("Lady Gaga", songs);
            Singer christinaAglira = new Singer("Christina Algira", songs);
            Judge SymonKavel = new Judge("Symon Kavel");
            SymonKavel.contest(ladyGaga, christinaAglira);
        }
    }
}