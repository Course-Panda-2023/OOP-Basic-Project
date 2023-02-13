using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPprojectS
{
    public class Judge
    {
        private string name;
        public Judge(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }
        public Performer judge(Performer s1, Performer s2)
        {
            Console.WriteLine("Judge " + this.name + " judges " + s1.getName() + ", " +
            s2.getName() + ":");
            s1.Sing();
            s2.Sing();
            Random r = new Random();
            double num = r.NextDouble();
            if (num >= 0.5)
            {
                Console.WriteLine("Performer " + s1.getName() + " wins!");
                return s1;
            }
            else
            {
                Console.WriteLine("Performer " + s2.getName() + " wins!");

                return s2;
            }
        }
    }
}