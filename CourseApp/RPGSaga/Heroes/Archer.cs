namespace CourseApp.RPGSaga.Heroes
{
    using System.Collections.Generic;
    using CourseApp.RPGSaga.Abilities;
    using CourseApp.RPGSaga.Interfaces;

    public class Archer : Player
    {
        private List<IAbility> _abilities;
        private List<IAbility> _effects;

        public Archer(string name, int hp, int strength)
            : base(name, hp, strength)
        {
            _abilities = new List<IAbility>();
            _effects = new List<IAbility>();
        }

        public override string ToString()
        {
            return $"Archer: {Name} HP: {HP} Strength: {Strength}";
        }

        public override void ApplyDamage(int damage)
        {
            throw new System.NotImplementedException();
        }

        public override List<IAbility> Abilities()
        {
            _abilities.Add(new Attack());
            _abilities.Add(new FireArrows());
            return _abilities;
        }

        public override List<IAbility> Effects(IAbility effect)
        {
            _effects.Add(effect);
            return _effects;
        }
    }
}