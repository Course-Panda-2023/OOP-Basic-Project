using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasicProject
{
    internal class SongCompetition
    {

        //private List<Singer> _singers;
        //private List<Guitarists> _guitarists;
        
        //private List<Competitor> _competitor;
        private List<People> _competitionPeople;
        private string _name;
        private Random _random;
        private List<Song> _songs;
        public SongCompetition()
        {
            /*_singers = new List<Singer>();
            _guitarists = new List<Guitarists>();
            _songs = new List<Song>();*/

            this._random = new Random();
        }
        public void AddSinger(Singer singer)
        {
            _competitionPeople.Add(singer);
        }
        public void AddGuitarist(Guitarists guitarist)
        {
            _competitionPeople.Add(guitarist);
        }
        public void AddSong(Song song)
        {
            _songs.Add(song);
        }
        public void AddJury(Jury jury)
        {
            _competitionPeople.Add(jury);
        }
        /*public void StartCompetition()
        {
            int singerIndex = _random.Next(0, _singers.Count);
            int guitaristIndex = _random.Next(0, _guitarists.Count);
            int songIndex = _random.Next(0, _songs.Count);
            *//*Console.WriteLine("Singer: {0}", _singers[singerIndex].ToString());
            Console.WriteLine("Guitarist: {0}", _guitarists[guitaristIndex].ToString());
            Console.WriteLine("Song: {0}", _songs[songIndex].ToString());*//*
        }*/
    }
}
