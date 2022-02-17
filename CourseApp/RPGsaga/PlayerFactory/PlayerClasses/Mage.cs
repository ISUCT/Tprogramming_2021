using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGsaga.PlayerFactory
{
    public class Mage : Player
    {
        public readonly string playerClass = "Mage";
        public Mage(string name, int health, int strength) : base(name, health, strength)
        {
            this.playerClass = "Mage";
        }
    }
}
