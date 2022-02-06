using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp.RPG_Saga
{
    public class Archer : Player
    {
        public Archer Create(string name, int health, int strenght)
        {
            return new(name, health, strenght);
        }
    }
}
