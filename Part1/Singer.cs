using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Singer
{
    private string mName;
    public string Name
    {
        get { return mName; }
        set { mName = value; }
    }
    private List<Song> mSongsList;
    public List<Song> SongsList
    {
        get { return mSongsList; }
        set { mSongsList = value; }
    }
    public Singer(string mName)
    {
        this.mName = mName;
        this.mSongsList = new List<Song>();
    }
    public Singer(string name, List<Song> songsList)
    {
        this.mName = name;
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