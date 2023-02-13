namespace Music
{
    class Singer : Person
    {
        public Singer(string fullName) : base(fullName) {  }
        
        public void Sing(string[] listSong)
        {
            Random rnd = new Random();
            int numberSong = rnd.Next(listSong.Length);
            Console.WriteLine($"{this.GetFullName()} is singing `{listSong[numberSong]}` now... ");
        }

    }
}