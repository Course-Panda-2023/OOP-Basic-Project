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

        List<Hero> heroes = new List<Hero>();

        public List<Hero> Heroes
        {
            get { return heroes; }
            set { heroes = value; }
        }
        public List<IIdol> GetIdols() 
        { 
            return idols;
        }

        private string name;

        public string Name {
            get { return name; }
        }

        public Idol(string name)
        {
            this.name = name;
        }

        public Idol(string name, params IIdol[] idols)
        {
            this.name = name;
            Add(idols);
        }

        public Idol(params IIdol[] idols)
        {
            Add(idols);
        }

        public Idol(List<Hero> heros, params IIdol[] idols)
        {
            Add(idols);
            bool isGuitar = false;
            bool isDrummer = false;
            foreach(var hero in CollectionsMarshal.AsSpan(heros))
            {
                if (hero is GuitarHero)
                {
                    isGuitar = true;
                }
                else if (hero is BoomTrachHero)
                {
                    isDrummer = true;
                }
                this.heroes.Add(hero);
            }
            if (!isGuitar || !isDrummer)
            {
                Console.WriteLine("Must be a drummer and a guitar hero");
            }
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

        public void SetHeroes(List<Hero> heroes)
        {
            foreach (var hero in CollectionsMarshal.AsSpan(heroes))
            {
                this.heroes.Add(hero);
            }
        }
    }
}
