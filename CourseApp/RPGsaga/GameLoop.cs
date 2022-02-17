using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGsaga.gameSessions;
using RPGsaga.PlayerFactory;

namespace RPGsaga
{
    public class GameLoop
    {
        Logger log = new Logger();
        PlayersCreator playersCreator = new PlayersCreator();
        public void firstPartOfTheGame()
        {
            log.greetPlayer();

            // Creating amount of players
            int numberNotCreated = playersCreator.CreatingPlayersNumber();
            while(numberNotCreated == 0)
            {
                Console.WriteLine("\n" + "You have entered wrong value, try again!" + "\n");
                numberNotCreated = playersCreator.CreatingPlayersNumber();
            }
            int numberOfPlayers = numberNotCreated;
            // --------------------------

            log.greetPlayersNames();

            //Creating players names
            List<string> names = new List<string>();
            for(int i = 0; i<numberOfPlayers; i++)
            {
                string correctName = playersCreator.CreatingPlayersNames();
                while(correctName.Length == 0)
                {
                    Console.WriteLine("\n" + "Your name is uncorrect, try again! (it must be between 2 and 12 characters)" + "\n");
                    correctName = playersCreator.CreatingPlayersNames();
                }
                names.Add(correctName);
                Console.WriteLine("\n" + $"Name was added: {correctName}" + "\n");
            }
            //----------------------

            log.greetPlayersAtrributes();

            //Creating players attributes
            List<Player> players = new List<Player>();
            for(int i = 0; i<names.Count; i++)
            {
                Console.WriteLine($"@@@@@ Choose {names[i]} class (1-mage, 2-archer, 3-knigth) @@@@@" + "\n");
                int correctClass = playersCreator.CreatingPlayersClass();
                string playerClass;
                while(correctClass == 0)
                {
                    Console.WriteLine("\n" + "You have entered wrong value, try again! (it must be between 1 and 3)" + "\n");
                    correctClass = playersCreator.CreatingPlayersClass();
                }
                if(correctClass == 1)
                {
                    playerClass = "Mage";
                }
                else if(correctClass == 2)
                {
                    playerClass = "Archer";
                }
                else
                {
                    playerClass = "Knigth";
                }
                Console.WriteLine("\n" + $"@@@@@ his/her/it class is {playerClass} @@@@@" + "\n");

                Console.WriteLine($"@@@@@ Let's give health to: {names[i]} @@@@@" + "\n");
                Console.WriteLine("his/her/it amount of health" + "\n");
                int correctHealth = playersCreator.CreatingPlayersHealth();
                while(correctHealth == 0)
                {
                    Console.WriteLine("\n" + "You have entered wrong value, try again! (it must be between 18 and 25)" + "\n");
                    correctHealth = playersCreator.CreatingPlayersHealth();
                }
                Console.WriteLine("\n" + $"his/her/it amount of health: {correctHealth}" + "\n");

                Console.WriteLine("@@@@@ Now give him/her/it some power @@@@@" + "\n");
                int correctStrength = playersCreator.CreatingPlayersStrength();
                while (correctStrength == 0)
                {
                    Console.WriteLine("\n" + "You have entered wrong value, try again! (it must be between 3 and 5)" + "\n");
                    correctStrength = playersCreator.CreatingPlayersStrength();
                }
                Console.WriteLine("\n" + $"his/her/it amount of strength: {correctStrength}" + "\n");

                if(playerClass == "Mage")
                {
                    Mage mage = new Mage(names[i], correctHealth, correctStrength);
                    players.Add(mage);
                }
                else if(playerClass == "Archer")
                {
                    Archer archer = new Archer(names[i], correctHealth, correctStrength);
                    players.Add(archer);
                }
                else
                {
                    Knigth knigth = new Knigth(names[i], correctHealth, correctStrength);
                    players.Add(knigth);
                }
                //--------------
            }

            log.greetSuccess();
            for(int i = 0; i < players.Count; i++)
            {
                if(players[i] is Mage)
                {
                    Console.WriteLine($"{players[i].name}: Class - Mage, Health - {players[i].health}, Strength - {players[i].strength}" + "\n");
                }
                else if(players[i] is Archer)
                {
                    Console.WriteLine($"{players[i].name}: Class - Archer, Health - {players[i].health}, Strength - {players[i].strength}" + "\n");
                }
                else
                {
                    Console.WriteLine($"{players[i].name}: Class - Knigth, Health - {players[i].health}, Strength - {players[i].strength}" + "\n");
                }
            }
        }
    }
}
