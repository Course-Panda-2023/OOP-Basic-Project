﻿using System;

namespace OOPBasicProject
{
    internal class Band : Competitor
    {

        private string _bandName;
        private int _bandAge;
        private string _bandCity;
        private string _bandCountry;
        //private Song _song;
        //private int _voteCount;
        private List<Competitor> _bandParticipants;
        private Random _random;
        //private Rando
        public Band(string name) : base(name, 0, "Unknown", "Unknown")
        {
            this._bandName = name;
            this._bandAge = 0;
            this._bandCity = "Unknown";
            this._bandCountry = "Unknown";
            this._random = new Random();
                       
            _bandParticipants = new List<Competitor>() {
                new Singer(Helper.RandomString(_random.Next(3, 10))),
                new Drummers(Helper.RandomString(_random.Next(3, 10))),
                new Guitarists(Helper.RandomString(_random.Next(3, 10)))};
            
        }
        public Band(string name, int age, string city, string country, List<Competitor> singers) : base(name, age, city, country)
        {
            this._bandName = name;
            this._bandAge = age;
            this._bandCity = city;
            this._bandCountry = country;
            this._bandParticipants = singers;
        }
        public void addParticipant(Competitor newParticipant)
        {
            if (newParticipant.GetType() is OOPBasicProject.Band)
            {
                Console.WriteLine("You can't add a band to a band");
                return;
            }
            _bandParticipants.Add(newParticipant);            
        }
        public string BandName
        {
            get { return _bandName; }
            set { _bandName = value; }
        }
        public int BandAge
        {
            get { return _bandAge; }
            set { _bandAge = value; }
        }
        public string BandCity
        {
            get { return _bandCity; }
            set { _bandCity = value; }
        }
        public string BandCountry
        {
            get { return _bandCountry; }
            set { _bandCountry = value; }
        }
        public new void SelectRandomSongFromList(List<Song> songList)
        {
            Random random = new Random();
            int randomSongIndex = random.Next(0, songList.Count);
            this.Song = songList[randomSongIndex];
            foreach (Competitor bandParticipant in _bandParticipants)
            {
                bandParticipant.Song = this.Song;
            }
        }
        /*public Song Song
        {
            get { return _song; }
            set { _song = value; }
        }*/
        /*public int VoteCount
        {
            get { return _voteCount; }
            set { _voteCount = value; }
        }*/

        public override string ToString()
        {
            return BandName;
        }
        public void PrintBandParticipants()
        {            
            foreach (Competitor bandParticipant in _bandParticipants)
            {
                Console.WriteLine(bandParticipant.ToString());
            }
        }
        public new void PerformSong()
        {
            //Console.WriteLine("The band {0} is performing", BandName);
            foreach (Competitor bandParticipant in _bandParticipants)
            {
                if(this.Song == null) 
                {
                    Console.WriteLine("The band {0} didn't get a song!", BandName);
                    return;
                } 
                bandParticipant.PerformSong();
                /*if (!bandParticipant.Performed)
                {
                    this.Performed = false;
                    return;
                }*/
            }
        }
        /*public new void Performed()
        {            
            //Console.WriteLine("The band {0} is performing", BandName);
            
        }*/
        /*public void SelectSongByBandParticipants(List<Song> songsList)
        {
            Helper.SelectingSongsBySingers(_bandParticipants, songsList);
        }*/
    }
}