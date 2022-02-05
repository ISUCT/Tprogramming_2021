namespace CourseApp.RPGSaga.Heroes
{
    public abstract class Player : IPlayer
    {
        private int _hp;
        private int _strength;

        public Player(string name, int hp, int strength)
        {
            Name = name;
            HP = hp;
            Strength = strength;
        }

        public string Name { get; set; }

        public int HP
        {
            get
            {
                return _hp;
            }

            set
            {
                if (value > 0)
                {
                    _hp = value;
                }
                else
                {
                    _hp = 10;
                }
            }
        }

        public int Strength
        {
            get
            {
                return _strength;
            }

            set
            {
                if (value > 0)
                {
                    _strength = value;
                }
                else
                {
                    _strength = 10;
                }
            }
        }
    }
}