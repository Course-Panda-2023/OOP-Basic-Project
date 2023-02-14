using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BandWithGuitarAndDrums : ContestParticipant
{
    private Drums mDrumer;
    public Drums Drumer
    {
        get { return mDrumer; }
        set { mDrumer = value; }
    }
    private Guitar mGuitarist;
    public Guitar Guitarist
    {
        get { return mGuitarist; }
        set { mGuitarist = value; }
    }
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
    public BandWithGuitarAndDrums(string name, List<Singer> singersList, Drums drumer, Guitar guitarist, List<Song> songsList) : base(name)
    {
        this.mSingersList = singersList;
        this.mDrumer = drumer;
        this.mGuitarist = guitarist;
        this.mSongList = songsList;
    }
}