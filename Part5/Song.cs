using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasicProject

{
    internal class Song
    {

        private string _name;
        private string _author;
        private string _duration;
        private string _releaseYear;
        public Song() { }
        public Song(string name, string artist, string duration, string releaseYear)
        {
            this._name = name;
            this._author = artist;
            this._duration = duration;
            this._releaseYear = releaseYear;
        }
        public Song(Song other)
        {
            this.Name = other.Name;
            this.Artist = other.Artist;
            this.Duration = other.Duration;
            this.ReleaseYear = other.ReleaseYear;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Artist
        {
            get { return _author; }
            set { _author = value; }
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
        public override string ToString()
        {
            return string.Format("Song name: {0}, Artist: {1}, Duration: {2}, Release year: {3}", _name, _author, _duration, _releaseYear);
        }
    }
}
