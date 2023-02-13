using System;
namespace OOPprojectS
{
    public class Band : Performer
	{
        private string bandName;
        List<Song> songList;
        List<Singer> singersList;

        public Band(string name, List<Song> songs, List<Singer> singers)
        {
            this.bandName = name;
            this.songList = new List<Song>(songs);
            this.singersList = singers;
            this.songList.Add(new Song("", ""));
        }
        public Band(string name, List<Song> songs)
        {
            this.bandName = name;
            this.songList = new List<Song>(songs);
            List<Singer> singers = new List<Singer>();
            singers.Add(new Singer("random guy", songs));
            this.singersList = singers;
            this.songList.Add(new Song("", ""));
        }

        public string getName()
        {
            return this.bandName;
        }

        public Song getRandomSongInList()
        {
            Random r = new Random();
            int len = this.songList.Count();
            if (len == 1)
            {
                return songList.ElementAt(0);
            }
            else
            {
                int indexOfsong = r.Next(0, len - 1);
                return songList.ElementAt(indexOfsong);
            }
        }

        public Song chooseSongFromList(List<Song> songsList)
        {
            if (songsList.Count == 0)
            {
                return new Song("", "");
            }
            Random rnd = new Random();
            int indexOfSong = rnd.Next(0, songList.Count - 1);
            Console.WriteLine("The singer " + this.getName() + " chose " + songsList.ElementAt(indexOfSong).getName() + " from the list:");
            foreach (Song s in songsList)
            {
                Console.WriteLine((s.getName()));
            }
            return songsList.ElementAt(indexOfSong);
        }

        public void Sing()
        {
            Console.Write("Now " + this.bandName + " consisting of ");
            foreach (Singer s in this.singersList)
            {
                Console.Write(s.getName() + " ");
            }
            Console.WriteLine(", sings:");
            Console.WriteLine(this.getRandomSongInList().getSong());
        }

        public void singFromList(List<Song> songsList)
        {
            Console.Write("Now " + this.bandName + " consisting of ");
            foreach (Singer s in this.singersList)
            {
                Console.Write(s.getName() + " ");
            }
            Console.WriteLine(", sings:"); Console.WriteLine(this.chooseSongFromList(songsList).getSong());
        }
    }
}

