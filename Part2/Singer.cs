namespace Music
{
    class Singer : Person
    {
        private string[] _songs;
        public Singer(string fullName, string[] songs) : base(fullName) 
        {
            this._songs = songs;
        }
        
        private string GetRandomSong()
        {
            Random rnd = new Random();
            int songNumber = rnd.Next(this._songs.Length);
            return this._songs[songNumber];
        }

        public void Sing()
        {
            Console.WriteLine($"{this.GetFullName()} is singing `{GetRandomSong()}` now... ");
        }

    }
}