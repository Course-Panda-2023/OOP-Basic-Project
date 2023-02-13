using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part5
{
    internal class Guitarist : Member
    {
        private string mName;
        private string mSong;
        public Guitarist(string name,string song)
        {
            //mSingers=new Singer[singers.Length];
            mSong = song;
            mName = name;
        }
        public string Song
        {
            get { return mSong; }
            set { mSong = value; }
        }
        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }

        public void Performance()
        {
            Console.WriteLine($"{mName}: *plays {mSong} on guitar*");
        }

    }
}
