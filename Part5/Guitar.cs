using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Guitar
{
    private string mName;
    public string Name
    {
        get { return mName; }
        set { mName = value; }
    }
    public Guitar(string name)
    {
        this.mName = name;
    }
}