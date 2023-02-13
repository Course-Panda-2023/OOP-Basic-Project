namespace MySingingContest
{
    class Band : Participant
    {
        private string name;
        private Song[] songs;
        private Singer[] members;

        public Band(string name, Singer[] members) 
        {
            this.name = name;
            this.songs = new Song[0];
            this.members = members;
        }
        public Band(string name, Song song, Singer[] members)
        {
            this.name = name;
            this.songs = new Song[1];
            this.songs[0] = song;
            this.members = members;
        }
        public Band(string name, Song[] songs, Singer[] members)
        {
            this.name = name; 
            this.songs = songs;
            this.members = members;
        }
        public Band(string name, string[] memberNames)
        {
            this.name = name;
            this.songs = new Song[0];
            this.members = new Singer[memberNames.Length];
            for (int i = 0; i < memberNames.Length; i++)
            {
                this.members[i] = new Singer(memberNames[i]);
            }
        }
        public string GetName() { return this.name; }
        public void AddSong(Song song)
        {
            this.songs = this.songs.Concat(new Song[] { song }).ToArray();
        }
        public Song[] GetSongs() { return this.songs; }
        public Song SingASong(int i = 0) 
        {
            string talk = $"{this.name}: we will be preforming {songs[i].GetName()}";
            string song = "";
            foreach (Singer member in this.members)
            {
                song += $"\n{member.GetName()}: ~ {songs[i].GetLyrics()} ~";
            }
            Console.WriteLine(talk+song);
            return this.songs[i];
        }
        public override string ToString()
        {
            string template = $"BAND NAME: {this.name}. SONGS:";
            foreach (Song song in this.songs)
            {
                template += song.ToString();
            }
            template += " MEMBERS: ";
            foreach (Singer member in this.members)
            {
                template += member.ToString();
            }
            return template;
        }
        public Song ChooseSong(Song[] songs)
        {
            Random rnd = new Random();
            return songs[rnd.Next(songs.Length)];
        }
    }
}