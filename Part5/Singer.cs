namespace Music
{
    class Singer : Competitor
    {
        public Singer(string fullName) : base(fullName) {  }
        
        public override void Action(string[] listSong)
        {
            Random rnd = new Random();
            int numberSong = rnd.Next(listSong.Length);
            Console.WriteLine($"{this.GetFullName()} is singing `{listSong[numberSong]}` now... ");
        }

        public override void Action(string songName)
        {
            Console.WriteLine($"{this.GetFullName()} is singing `{songName}` now... ");
        }
    }
}