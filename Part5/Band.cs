namespace Music
{
    class Band : Competitor
    {
        private List<Singer> _singersInBand;

        public Band(string fullName) : base(fullName)
        {
            _singersInBand = new List<Singer>();
        }

        public override void Action(string[] listSong)
        {
            Random rnd = new Random();
            int numberSong = rnd.Next(listSong.Length);
            Console.WriteLine($"{this.GetFullName()} are singing `{listSong[numberSong]}` now... ");
        }

        public override void Action(string songName)
        {
            Console.WriteLine($"{this.GetFullName()} are singing `{songName}` now... ");
        }
    }
}