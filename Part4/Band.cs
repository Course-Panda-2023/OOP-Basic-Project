using OOPFinal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Band : Person , Participant 
{
    private List<Singer> singer;
    private List<Song> song;
    public Band(string name , List<Singer> singers, List<Song> songs) : base(name)
    {
        this.singer = singers;
        this.song = songs;
    }
    public string GetName() { return this.Name; }
}

