using System.Collections.Generic;  

class Singer : Competitor
{
    private uint age;
    public Singer(string name, List<Song> songs, int numOfFans, uint age) : base(name, songs, numOfFans)
    {
        this.age = age;
    }

}