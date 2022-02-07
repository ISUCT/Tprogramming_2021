namespace CourseApp
{
    using System;

    public abstract class Hero : IHero
    {
        private double health;
        private double damage;
        private double stamina;

        public string Class { get; set; }

        public string Name { get; set; }

        public bool Dead { get; set; }

        public double StartHealth { get; set; }

        public int Ulta { get; set; }

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