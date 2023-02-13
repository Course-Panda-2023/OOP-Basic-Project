namespace Music
{
    class Band : Competitor
    {
        private List<Singer> _singersInBand;

        public Band(string fullName) : base(fullName)
        {
            _singersInBand = new List<Singer>();
        }

        //public Band(string fullName, List<Singer> singersInBand) : base(fullName)
        //{
        //    _singersInBand = singersInBand;
        //}

        public override void Sing(string[] listSong)
        {
            Random rnd = new Random();
            int numberSong = rnd.Next(listSong.Length);
            Console.WriteLine($"{this.GetFullName()} are singing `{listSong[numberSong]}` now... ");
        }
    }
}