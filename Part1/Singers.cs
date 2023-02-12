using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Advanced_local
{
   class Singers : People
    {
        private string _singerName;
        private string _singerAge;
        private string _singerCity;
        private string _singerCountry;
        /*private string _singerSong;
        private string _singerSongDuration;
        private string _singerSongReleaseYear;*/
        private Song _singerSong;
        
        public Singers(string name, string age, string city, string country, Song song) : base(name, age, city, country)
        {
            _singerName = name;
            _singerAge = age;
            _singerCity = city;
            _singerCountry = country;
            _singerSong = song;
        }
        public string SingerName
        {
            get { return _singerName; }
            set { _singerName = value; }
        }
        public string SingerAge
        {
            get { return _singerAge; }
            set { _singerAge = value; }
        }
        public string SingerCity
        {
            get { return _singerCity; }
            set { _singerCity = value; }
        }
        public string SingerCountry
        {
            get { return _singerCountry; }
            set { _singerCountry = value; }
        }
        public Song SingerSong
        {
            get { return _singerSong; }
            set { _singerSong = value; }
        }
        
    }
}
