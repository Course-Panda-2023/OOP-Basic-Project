using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Song
{
    private string mSongName;
    public string SongName
    {
        get { return mSongName; }
        set { mSongName = value; }
    }
    public Song(string songName)
    {
        this.mSongName = songName;
    }
}