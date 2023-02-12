using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Band : ContestParticipant
{
    private List<Singer> mSingersList;
    public List<Singer> SingersList
    {
        get { return mSingersList; }
        set { mSingersList = value; }
    }
    private List<Song> mSongList;
    public List<Song> SongList
    {
        get { return mSongList; }
        set { mSongList = value; }
    }
    public Band(string name, List<Singer> singersList, List<Song> songsList) : base(name)
    {
        this.mSingersList = singersList;
        this.mSongList = songsList;
    }
}