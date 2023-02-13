namespace MySingingContest
{
    class Band : Participant
    {
        private string name;
        private Song[] songs;
        private Singer[] singers;
        private Drummer drummer;
        private Guitarist guitarist;

        private Band(string name, Drummer drummer, Guitarist guitarist)
        {
            this.name = name;
            this.drummer = drummer;
            this.guitarist = guitarist;

        }
        public Band(string name, Singer[] singers, Drummer drummer, Guitarist guitarist) : this(name, drummer, guitarist)
        {
            this.songs = new Song[0];
            this.singers = singers;
        }
        public Band(string name, Song song, Singer[] singers, Drummer drummer, Guitarist guitarist) : this(name, singers, drummer, guitarist)
        {
            this.songs = new Song[1];
            this.songs[0] = song;
        }
        public Band(string name, Song[] songs, Singer[] singers, Drummer drummer, Guitarist guitarist) : this(name, drummer, guitarist)
        {
            this.songs = songs;
            this.singers = singers;
        }
        public Band(string name, string[] singerNames, string drummerName, string guitaristName)
        {
            this.name = name;
            this.songs = new Song[0];
            this.singers = new Singer[singerNames.Length];
            for (int i = 0; i < singerNames.Length; i++)
            {
                this.singers[i] = new Singer(singerNames[i]);
            }
            this.drummer = new Drummer(drummerName);
            this.guitarist = new Guitarist(guitaristName);
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
            foreach (Singer singer in this.singers)
            {
                song += $"\n{singer.GetName()}: ~ {songs[i].GetLyrics()} ~";
            }
            string music = $"\n{ drummer.GetName()}: < dum dum dum >";
            music += $"\n{guitarist.GetName()}: < dan dan >";
            Console.WriteLine(talk+song+music);
            return this.songs[i];
        }
        public override string ToString()
        {
            string template = $"BAND NAME: {this.name}. SONGS:";
            foreach (Song song in this.songs)
            {
                template += song.ToString();
            }
            template += " SINGERS: ";
            foreach (Singer singer in this.singers)
            {
                template += singer.ToString();
            }
            template += $"DRUMMER: {this.drummer}.";
            template += $"GUITARIST: {this.guitarist}.";
            return template;
        }
        public Song ChooseSong(Song[] songs)
        {
            Random rnd = new Random();
            return songs[rnd.Next(songs.Length)];
        }
    }
}