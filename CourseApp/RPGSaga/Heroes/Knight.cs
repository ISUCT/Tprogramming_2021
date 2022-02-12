namespace CourseApp.RPGSaga.Heroes
{
    using System;
    using System.Collections.Generic;
    using CourseApp.RPGSaga.Abilities;
    using CourseApp.RPGSaga.GameBuilder;
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
                    Logger.WriteLog($"{GetType()} {Name} is frozen right now, so he miss this step");
                }

                if (effect.IsFire)
                {
                    IsFire = true;
                    Logger.WriteLog($"{GetType()} {Name} is burning now");
                }

                if (IsFire)
                {
                    Hp -= 2;
                }

                Hp -= effect.Damage;
                Logger.WriteLog($"{GetType()} {Name} has {Hp} HP");
                if (Hp <= 0)
                {
                    IsDead = true;
                    return;
                }

                effect.ActionDuration -= 1;
                if (effect.ActionDuration == 0)
                {
                    _effects.Remove(effect);
                    Logger.WriteLog($"Duration of {effect.Name} is ended");
                }
            }

            if (!_isSkip)
            {
                SetDamage();
            }
        }

        public override void AddEffect(IAbility effect)
        {
            _effects.Add(effect);
        }

        public override void SetTarget(IPlayer enemy)
        {
            _enemy = enemy;
        }

        public override void SetDamage()
        {
            var randomIndex = Random.Shared.Next(0, _abilities.Count);
            _enemy.AddEffect(_abilities[randomIndex]);
            Logger.WriteLog($"{GetType()} {Name} used {_abilities[randomIndex].Name} against {GetType()} {_enemy.Name}");
            _abilities[randomIndex].NumOfUses -= 1;
            if (_abilities[randomIndex].NumOfUses == 0)
            {
                _abilities.RemoveAt(randomIndex);
                Logger.WriteLog($"{GetType()} {Name} used maximum times of {_abilities[randomIndex].Name}");
            }
        }

        public override string ToString()
        {
            return $"Knight: {Name} HP: {Hp} Strength: {Strength}";
        }
    }
}