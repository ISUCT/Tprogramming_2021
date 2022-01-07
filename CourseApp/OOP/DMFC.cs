using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class DMFC : MFC //добавляем ещё одного ребёнка
    {
        protected string child2;

        public DMFC(string m, string f, string c, string d) : base (m, f, c)
        {
            child2 = d;
        }

        public override string GetChild()
        {
            return child +", "+ child2;

        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Второй ребёнок: " + child2);
        }
    }

}
