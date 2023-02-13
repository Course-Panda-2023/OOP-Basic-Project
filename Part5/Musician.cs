using System;
namespace OOPprojectS
{
	public abstract class Musician : Performer
	{
        public string name;
        protected List<Song> songList;

        abstract public string getProffession();

        abstract public void Sing();

        public Musician(string name, List<Song> songList)
        {
            this.name = name;
            List<Song> songListCopy = new List<Song>(songList);
            songListCopy.Add(new Song("", ""));
            this.songList = songListCopy;
        }

        public string getName()
        {
            return this.name;
        }

        abstract public void singFromList(List<Song> songsList);

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
            int indexOfSong = rnd.Next(0, songsList.Count - 1);
            Console.WriteLine("The " + this.getProffession + " " + this.getName() + " chose " + songsList.ElementAt(indexOfSong).getName() + " from the list:");
            foreach (Song s in songsList)
            {
                Console.WriteLine((s.getName()));
            }
            return songsList.ElementAt(indexOfSong);
        }

    }
}

