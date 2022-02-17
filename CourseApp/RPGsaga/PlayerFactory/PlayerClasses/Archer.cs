using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGsaga.PlayerFactory
{
    public class Archer : Player
    {
        public readonly string playerClass = "Archer";
        public Archer(string name, int health, int strength) : base(name, health, strength)
        {
            this.playerClass = "Archer";
        }
    }
}
