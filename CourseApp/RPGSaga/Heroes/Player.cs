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
            IsFire = false;
        }

        public string Name { get; set; }

        public int Hp { get; protected set; }

        public int Strength
        {
            get => _strength;

            set => _strength = value > 0 ? value : 50;
        }

        public bool IsFire { get; set; }

        public bool IsDead { get; set; }

        public abstract void MakeAMove();

        public abstract void AddEffect(IAbility effect);

        public abstract void SetTarget(IPlayer enemy);

        public abstract void SetDamage();

        public abstract void SetDefaultValues();

        protected abstract void AddAbilities();
    }
}