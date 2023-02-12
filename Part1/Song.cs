using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Advanced_local
{
    class Song {
        /*public string Name { get; set; }
        public string Artist { get; set; }
        public string Duration { get; set; }
        public Song(string name, string artist, string duration)
        {
            Name = name;
            Artist = artist;
            Duration = duration;
        }*/
        private string _name;
        private string _artist;
        private string _duration;
        private string _releaseYear;
        public Song(string name, string artist, string duration, string releaseYear)
        {
            _name = name;
            _artist = artist;
            _duration = duration;
            _releaseYear = releaseYear;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Artist
        {
            get { return _artist; }
            set { _artist = value; }
        }
        public string Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }
        public string ReleaseYear
        {
            get { return _releaseYear; }
            set { _releaseYear = value; }
        }
    }
}
