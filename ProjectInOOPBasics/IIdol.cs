using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectInOOPBasics
{
    internal interface IIdol
    {
        void SetHeroes(List<Hero> heroes);
        List<IIdol> GetIdols();
        void AddOne(IIdol idol);
        string GetName();
        int Size();
        void CopyByVal(List<IIdol> idolsAsList);
        void SetName(string name);
        void Execute();
    }
}
