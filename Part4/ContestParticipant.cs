using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
abstract class ContestParticipant
{
    protected string mName;
    public string Name
    {
        get { return mName; }
        set { mName = value; }
    }
    public ContestParticipant(string name)
    {
        this.mName = name;
    }
}