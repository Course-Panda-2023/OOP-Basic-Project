namespace MySingingContest
{
    class Singer : Musician, Participant
    {
        private string name;
        private Song[] songs;

        public Singer(string name) 
        {
            this.name = name;
            this.songs = new Song[0];
        }
        public Singer(string name, Song song)
        {
            this.name = name;
            this.songs = new Song[1];
            this.songs[0] = song;
        }
        public Singer(string name, Song[] songs)
        {
            this.name = name; 
            this.songs = songs;
        }
        public override string GetName() { return this.name; }
        public void AddSong(Song song)
        {
            this.songs = this.songs.Concat(new Song[] { song }).ToArray();
        }
        public Song[] GetSongs() { return this.songs; }
        public Song SingASong(int i = 0) 
        {
            string talk = $"{this.name}: I'll be preforming {songs[i].GetName()} \n";
            string song = $"{this.name}: ~ {songs[i].GetLyrics()} ~";
            Console.WriteLine(talk+song);
            return this.songs[i];
        }
        public override string ToString()
        {
            string template = $" singer name: {this.name}. songs:";
            foreach (Song song in this.songs)
            {
                template += song.ToString();
            }
            return template;
        }
        // Part 3:
        public Song ChooseSong(Song[] songs)
        {
            Random rnd = new Random();
            return songs[rnd.Next(songs.Length)];
        }
    }
}