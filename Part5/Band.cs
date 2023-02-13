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
    private Guitarist guitarist;
    private Drummer drummer;
        
    public Band(string name , List<Singer> singers, Drummer drummer, Guitarist guitarist,  List<Song> songs) : base(name)
    {
        this.singer = singers;
        this.song = songs;
        this.drummer = drummer;
        this.guitarist = guitarist;
    }
    public string GetName() { return this.Name; }
}

