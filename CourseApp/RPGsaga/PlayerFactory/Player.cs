using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGsaga.PlayerFactory
{
    public abstract class Player
    {
        //Setting player Attributes
        public readonly string playerClass;
        public string? name;
        /*public string Name { 
            get 
            { 
                return name;
            }
            private set
            {
                if(value.Length < 2 || value.Length > 12)
                {
                    this.name = "";
                }
                else
                {
                    this.name = value;
                }
            }
        }*/

        public int health;
        /*public int Health
        {
            get
            {
                return health;
            }
            set
            {
                if(value < 0 || value > 25)
                {
                    this.health = 0;
                }
                else
                {
                    this.health = value;
                }
            }
        }*/

        public int strength;
        /*public int Strength
        {
            get
            {
                return strength;
            }
            set
            {
                if(value < 0 || value > 5)
                {
                    this.strength = 0;
                }
                else
                {
                    this.strength = value;
                }
            }
        }*/
        // ------------------------

        public Player(string name, int health, int strength)
        {
            this.name = name;
            this.health = health;
            this.strength = strength;
        }
    }
}
