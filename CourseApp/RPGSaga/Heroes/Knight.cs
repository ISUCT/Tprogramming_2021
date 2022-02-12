namespace CourseApp.RPGSaga.Heroes
{
    using System;
    using System.Collections.Generic;
    using CourseApp.RPGSaga.Abilities;
    using CourseApp.RPGSaga.Interfaces;

    public class Knight : Player
    {
        private bool _isSkip;
        private IPlayer _enemy;
        private List<IAbility> _abilities;
        private List<IAbility> _effects;

        public Knight(string name, int hp, int strength)
            : base(name, hp, strength)
        {
            _abilities = new List<IAbility>() { new Attack(Strength), new VengeanceStrike(Strength) };
            _effects = new List<IAbility>();
        }

        public override void MakeAMove()
        {
            _isSkip = false;
            foreach (var effect in _effects)
            {
                if (effect.IsSkipRound)
                {
                    _isSkip = true;
                }

                if (IsFire)
                {
                    Hp -= 2;
                }

                Hp -= effect.Damage;
                if (Hp <= 0)
                {
                    IsDead = true;
                    return;
                }

                effect.ActionDuration -= 1;
            }

            if (!_isSkip)
            {
                SetDamage();
            }
        }

        public override void SetTarget(IPlayer enemy)
        {
            _enemy = enemy;
        }

        public override void SetDamage()
        {
            var randomIndex = Random.Shared.Next(0, _abilities.Count);
            _enemy.AddEffect(_abilities[randomIndex]);
            _abilities[randomIndex].NumOfUses -= 1;
            if (_abilities[randomIndex].NumOfUses == 0)
            {
                _abilities.RemoveAt(randomIndex);
            }
        }

        public override void AddEffect(IAbility effect)
        {
            _effects.Add(effect);
        }

        public override string ToString()
        {
            return $"Knight: {Name} HP: {Hp} Strength: {Strength}";
        }
    }
}