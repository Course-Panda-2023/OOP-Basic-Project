using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Drums
{
    private string mName;
    public string Name
    {
        get { return mName; }
        set { mName = value; }
    }
    public Drums(string name)
    {
        this.mName = name;
    }
}