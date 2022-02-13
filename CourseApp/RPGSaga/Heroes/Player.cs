namespace CourseApp.RPGSaga.Heroes
{
    using System.Collections.Generic;
    using CourseApp.RPGSaga.Interfaces;

    public abstract class Player : IPlayer, ISetTarget
    {
        private int _strength;

        public Player(string name, int hp, int strength)
        {
            Name = name;
            Hp = hp;
            Strength = strength;
            IsDead = false;
        }

        public string Name { get; set; }

        public int Hp { get; protected set; }

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

        public bool IsFire { get; set; }

        public bool IsDead { get; set; }

        public abstract void MakeAMove();

        public abstract void AddEffect(IAbility effect);

        public abstract void SetTarget(IPlayer enemy);

        public abstract void SetDamage();
    }
}