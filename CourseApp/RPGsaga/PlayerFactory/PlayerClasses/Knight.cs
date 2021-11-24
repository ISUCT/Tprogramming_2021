using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGsaga.PlayerFactory
{
    public class Knigth : Player
    {
        public readonly string playerClass = "Knigth";
        public Knigth(string name, int health, int strength) : base(name, health, strength)
        {
            this.playerClass = "Knigth";
        }
    }
}
