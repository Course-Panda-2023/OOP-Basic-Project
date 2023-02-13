namespace MySingingContest
{
    interface Participant
    {
        public string GetName();
        public void AddSong(Song song);
        public Song[] GetSongs();
        public Song SingASong(int i = 0);
        public string ToString();
        public Song ChooseSong(Song[] songs);
    }
}