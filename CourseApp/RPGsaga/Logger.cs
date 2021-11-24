using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGsaga
{
    public class Logger
    {
        public void greetPlayer()
        {
            Console.WriteLine("Greetings dear traveller!" + "\n" + "Now you have to create even number of characters, choose their names," + 
                              "\n" + "amount of health and strength! Make your choise wisely!" + "\n");

            Console.WriteLine("@@@@@ How many of them do you want? (number should be even) @@@@@" + "\n");
        }
        public void greetPlayersNames()
        {
            Console.WriteLine("\n" + "@@@@@ Now you should choose their names @@@@@" + "\n");
        }
        public void greetPlayersAtrributes()
        {
            Console.WriteLine("@@@@@ Now you should give them some attributes and choose their class @@@@@" + "\n");
        }
        public void greetSuccess()
        {
            Console.WriteLine("@@@@@ You have successfully created these characters @@@@@" + "\n");
        }
    }
}
