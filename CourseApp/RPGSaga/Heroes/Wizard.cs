namespace CourseApp.RPGSaga.Heroes
{
    using System.Collections.Generic;
    using CourseApp.RPGSaga.Abilities;
    using CourseApp.RPGSaga.Interfaces;

    public class Wizard : Player
    {
        private List<IAbility> _abilities;
        private List<IAbility> _effects;

        public Wizard(string name, int hp, int strength)
            : base(name, hp, strength)
        {
            _abilities = new List<IAbility>();
            _effects = new List<IAbility>();
        }

        public override void ApplyDamage(int damage)
        {
        }

        public override List<IAbility> Abilities()
        {
            _abilities.Add(new Attack());
            _abilities.Add(new Spellbinding());
            return _abilities;
        }

        public override List<IAbility> Effects(IAbility effect)
        {
            _effects.Add(effect);
            return _effects;
        }

        public override string ToString()
        {
            return $"Wizard: {Name} HP: {HP} Strength: {Strength}";
        }
    }
}