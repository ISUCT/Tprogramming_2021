using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGsaga.PlayerFactory;

namespace RPGsaga.gameSessions
{
    public class PlayersCreator
    {
        public int CreatingPlayersNumber()
        {
            int numberOfCharacters;
            string stringInput = Console.ReadLine();
            bool checkInput = int.TryParse(stringInput, out numberOfCharacters) == true && Convert.ToInt32(stringInput) % 2 == 0 && Convert.ToInt32(stringInput) != 0;
            if (checkInput)
            {
                numberOfCharacters = Convert.ToInt32(stringInput);
                return numberOfCharacters;
            }
            else
            {
                return 0;
            }
        }

        CheckPlayerAttributes checkPlayerAttributes = new CheckPlayerAttributes();

        public string CreatingPlayersNames()
        {
            string name = Console.ReadLine();
            if (checkPlayerAttributes.checkPlayerName(name))
            {
                return name;
            }
            else
            {
                return "";
            }
        }

        public int CreatingPlayersHealth()
        {
            int health;
            string inputHealth = Console.ReadLine();
            bool checkInput = int.TryParse(inputHealth, out health) == true;
            if (checkInput)
            {
                health = Convert.ToInt32(inputHealth);
            }
            else
            {
                Console.WriteLine("\n" + "It's should be a number" + "\n");
                return CreatingPlayersHealth();
            }

            if (checkPlayerAttributes.checkPlayerHealth(health))
            {
                return health;
            }
            else
            {
                return 0;
            }
        }

        public int CreatingPlayersStrength()
        {
            int strength;
            string inputStrength = Console.ReadLine();
            bool checkInput = int.TryParse(inputStrength, out strength) == true;
            if (checkInput)
            {
                strength = Convert.ToInt32(inputStrength);
            }
            else
            {
                Console.WriteLine("\n" + "It's should be a number" + "\n");
                return CreatingPlayersStrength();
            }

            if (checkPlayerAttributes.checkPlayerStrength(strength))
            {
                return strength;
            }
            else
            {
                return 0;
            }
        }

        public int CreatingPlayersClass()
        {
            int playerClass;
            string inputClass = Console.ReadLine();
            bool checkInput = int.TryParse(inputClass, out playerClass) == true;
            if (checkInput)
            {
                playerClass = Convert.ToInt32(inputClass);
            }
            else
            {
                Console.WriteLine("\n" + "It's should be a number" + "\n");
                return CreatingPlayersClass();
            }

            if (checkPlayerAttributes.checkPlayerClass(playerClass))
            {
                return playerClass;
            }
            else
            {
                return 0;
            }
        }
    }
}
