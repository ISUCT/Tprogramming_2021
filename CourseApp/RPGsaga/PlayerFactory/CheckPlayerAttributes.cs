using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGsaga.PlayerFactory
{
    public class CheckPlayerAttributes
    {
        public bool checkPlayerName(string name)
        {
            if(name.Length < 2 || name.Length > 12)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool checkPlayerHealth(int health)
        {
            if (health < 18 || health > 25)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool checkPlayerStrength(int strength)
        {
            if (strength < 3 || strength > 5)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool checkPlayerClass(int playerClass)
        {
            if(playerClass < 1 || playerClass > 3)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
