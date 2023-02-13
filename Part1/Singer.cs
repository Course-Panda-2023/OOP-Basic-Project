using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Singer : ContestParticipant
{
    private List<Song> mSongsList;
    public List<Song> SongsList
    {
        get { return mSongsList; }
        set { mSongsList = value; }
    }
    public Singer(string name) : base(name)
    {
        this.mSongsList = new List<Song>();
    }
    public Singer(string name, List<Song> songsList) : base(name)
    {
        this.mSongsList = songsList;
    }
    public void AddSong(Song song)
    {
        this.mSongsList.Add(song);
    }
    public void RemoveSong(Song song)
    {
        this.mSongsList.Remove(song);
    }
}