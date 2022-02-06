using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp.RPG_Saga
{
    public class Knight : Player
    {
        private Random random = new ();

        public Knight()
        {
            Health = random.Next(100, 200);

            Name = name;

            Strenght = random.Next(10, 20);
        }
    }
}
