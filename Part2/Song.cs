namespace MySingingContest
{
    class Song
    {
        private string name;
        private string lyrics;

        public Song(string name, string lyrics)
        {
            this.name = name;
            this.lyrics = lyrics;
        }
        public string GetName() { return name; }
        public string GetLyrics() { return this.lyrics; }
        public override string ToString() 
        { 
            return $"song name: {this.name} lyrics: {this.lyrics}";
        }
    }
}