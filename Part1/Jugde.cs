using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Judge
{
    private string mName;
    public string Name
    {
        get { return mName; }
        set { mName = value; }
    }
    public Judge(string mName)
    {
        this.mName = mName;
    }
}