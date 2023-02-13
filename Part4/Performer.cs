using System;

namespace OOPprojectS
{
    public interface Performer
	{
		public void Sing();

		public string getName();

		public void singFromList(List<Song> songsList);

		public Song getRandomSongInList();

		public Song chooseSongFromList(List<Song> songsList);

    }
}

