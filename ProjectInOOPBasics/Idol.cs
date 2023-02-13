using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectInOOPBasics
{
    internal class Idol : IIdol
    {
        List<IIdol> idols = new List<IIdol>();

        public List<IIdol> GetIdols() 
        { 
            return idols;
        }

        private string name;

        public string Name {
            get { return name; }
        }

        public Idol(params IIdol[] idols)
        {
            Add(idols);
        }

        public void AddOne(IIdol idol)
        {
            idols.Add(idol);
        }

        public void Add(params IIdol[] idols)
        {
            Span<IIdol> idolsAsSpan = idols.AsSpan();
            foreach (var idol in idolsAsSpan)
            {
                this.idols.Add(idol);
            }
        }

        public void CopyByVal(List<IIdol> idolsAsList)
        {
            var iterator = CollectionsMarshal.AsSpan(idols);
            foreach (var idolName in iterator)
            {
                idolsAsList.Add(idolName);
            }
        }

        public void Execute()
        {
            var iterator = CollectionsMarshal.AsSpan(idols);
            foreach (var idol in iterator)
            {
                idol.Execute();
            }
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public int Size()
        {
            return idols.Count;
        }

        public string GetName()
        {
            return name;
        }
    }
}
