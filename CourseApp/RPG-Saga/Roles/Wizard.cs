using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp.RPG_Saga
{
    public class Wizard : Player
    {
        public Wizard(string name, int health, int strenght)
        {
            Health = health;

            Name = name;

            Strenght = strenght;
        }
    }
}
