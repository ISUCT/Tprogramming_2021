namespace CourseApp
{
    using System;

    public abstract class Player : IPlayer
    {
        private double health;
        private int strength;
        private Random random = new Random();
        private double isFire = 0;
        private double isFrozen = 0;

        public Player(string name, double health, int strength)
        {
            health = random.Next(10, 50);
            strength = random.Next(5, 20);
            Name = name;
            Health = health;
            Strength = strength;
            IsFrozen = isFrozen;
            IsFire = isFire;
        }

        public string Name { get; set; }

        public double Health
        {
            get
            {
                return health;
            }

            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("gg wp");
                }
                else
                {
                    health = value;
                }
            }
        }

        public int Strength
        {
            get
            {
                return strength;
            }

            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("gg wp");
                }
                else
                {
                    strength = value;
                }
            }
        }

        public virtual double IsFrozen { get; set; }

        public virtual double IsFire { get; set; }
    }
}