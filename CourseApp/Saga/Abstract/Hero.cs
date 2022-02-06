namespace CourseApp
{
    using System;

    public abstract class Hero : IHero
    {
        private double health;
        private double damage;
        private double stamina;
        private Random random = new Random();

        public Hero(string name, double health, double damage, double stamina)
        {
            health = random.Next(30, 50);
            damage = random.Next(5, 10);
            stamina = random.Next(30, 100);
            this.Name = name;
            this.Health = health;
            this.Damage = damage;
            this.Stamina = stamina;
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
                    throw new InvalidOperationException("Ошибка");
                }
                else
                {
                    health = value;
                }
            }
        }

        public double Stamina
        {
            get
            {
                return stamina;
            }

            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("Ошибка");
                }
                else
                {
                    stamina = value;
                }
            }
        }

        public double Damage
        {
            get
            {
                return damage;
            }

            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("Ошибка");
                }
                else
                {
                    damage = value;
                }
            }
        }
    }
}