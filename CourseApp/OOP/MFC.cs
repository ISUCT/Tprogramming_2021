using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class MFC
    {
        protected string mother;
        protected string father;
        protected string child;

        public MFC(string m, string f, string c)

        {
            mother = m;
            father = f;
            child = c;

        }
        public virtual string GetChild()
        {
            return child;
        }

        public virtual void Print()
        {
            Console.WriteLine("Mать: " + mother + "  отец: " + father + "  ребенок: " + child);
        }

        public virtual void Tir()
        {
            Console.WriteLine("_____________________________");
        }

        

        
    }
}


