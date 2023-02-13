// See https://aka.ms/new-console-template for more information

/*
 * TODO: Write code for part1.
 * Notice: You need to implement the project structure yourself.
 */

using System.Globalization;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using OOPBasicProject;

List<OOPBasicProject.Song> CompetitionSongList = new List<OOPBasicProject.Song>();
CompetitionSongList.Add(new OOPBasicProject.Song("Song 1", "Author 1", "3:00", "2019"));
CompetitionSongList.Add(new OOPBasicProject.Song("Song 2", "Author 2", "3:00", "2018"));

List<OOPBasicProject.Singer> singers = new List<OOPBasicProject.Singer>();
singers.Add(new OOPBasicProject.Singer("Ledy Gaga", 36, "New York", "USA"));
singers.Add(new OOPBasicProject.Singer("Christina Aguilera", 42, "New York", "USA"));

List<OOPBasicProject.Jury> juries = new List<OOPBasicProject.Jury>();
juries.Add(new OOPBasicProject.Jury("Simon Cowell", 63, "London", "UK"));

Helper.SelectingSongsBySingers(singers, CompetitionSongList);
Dictionary<OOPBasicProject.Singer, int> voteCounts = new Dictionary<OOPBasicProject.Singer, int>();
Singer absoluteWinner = Helper.GetAbsoluteWinner(Helper.GetVotesFromJury(singers, juries));

Console.WriteLine("The winner of the song competition is: " + absoluteWinner.Name);
Console.ReadLine();
