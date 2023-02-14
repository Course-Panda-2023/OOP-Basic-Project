namespace Music
{
    class ExpendBand : Band
    {
        private List<Singer> _singers;
        private List<Drummer> _drummers;
        private List<Guitarist> _guitarists;

        public ExpendBand(string fullName, List<Singer> singers, List<Drummer> drummers, List<Guitarist> guitarists) : base(fullName)
        {
            _singers = singers;
            _drummers = drummers;
            _guitarists = guitarists;
        }

        public override void Action(string[] listSong)
        {
            // Choose random song 
            Random rnd = new Random();
            int numberSong = rnd.Next(listSong.Length);
            Console.WriteLine($"{_fullName} band is playing now...");
            // Let all singers sing the same song
            //foreach (Singer singer in _singers)
            //    singer.Action(listSong[numberSong]);
            //foreach (Drummer drummer in _drummers)
            //    drummer.Action();
            //foreach (Guitarist guitarist in _guitarists)
            //    guitarist.Action();
        }

    }
}