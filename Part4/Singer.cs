﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasicProject
{
   internal class Singer : Competitor
    {
        private string _singerName;
        private int _singerAge;
        private string _singerCity;
        private string _singerCountry;
        /*private string _singerSong;
        private string _singerSongDuration;
        private string _singerSongReleaseYear;*/
        private Song _singerSong;
        private Random _random;
        //public Singer() { }
        /*public Singer () : base()
        {
            _random = new Random();
            _singerName = RandomString(_random.Next(3,12));
            _singerAge = 0;
            _singerCity = "Unknown";
            _singerCountry = "Unknown";
            _singerSong = new Song("Unknown", "Unknown", "Unknown", "Unknown");
        }*/
        public Singer(string name) : base(name,  0, "Unknown", "Unknown")
        {
            _singerName = name;
            _singerAge = 0;
            _singerCity = "Unknown";
            _singerCountry = "Unknown";
            _singerSong = new Song("Unknown", "Unknown", "Unknown", "Unknown");
        }
        public Singer(string name, int age, string city, string country) : base(name, age, city, country)
        {
            _singerName = name;
            _singerAge = age;
            _singerCity = city;
            _singerCountry = country;            
        }
        public Singer(string name, int age, string city, string country, Song song) : base(name, age, city, country)
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
        public int SingerAge
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
        public void SelectRandomSongFromList(List<Song> songList)
        {
            Random random = new Random();
            int randomSongIndex = random.Next(0, songList.Count);
            _singerSong = songList[randomSongIndex];
        }
        public override string ToString()
        {
            //return string.Format("Name: {0}, Age: {1}, City: {2}, Country: {3}, Song: {4}", _singerName, _singerAge, _singerCity, _singerCountry, _singerSong);
            return string.Format("{0}", _singerName);
        }
    }
}
