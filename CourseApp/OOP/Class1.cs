using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class VMFC : DMFC

    {
        protected string lastname;
        public VMFC(string m, string f, string c, string d, string ln) : base(m, f, c, d)
        {
            lastname = ln;
        }

        public override void Print()
        {
            Console.WriteLine("Фамилия семьи {0}", lastname);
            base.Print();

        }
        public string GetName()
        {
            return lastname;
        }
    }
}
