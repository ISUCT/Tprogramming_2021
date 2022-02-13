namespace CourseApp.RPGSaga.Heroes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using CourseApp.RPGSaga.Abilities;
    using CourseApp.RPGSaga.GameBuilder;
    using CourseApp.RPGSaga.Interfaces;

    public class Wizard : Player
    {
        private bool _isSkip;
        private IPlayer _enemy;
        private List<IAbility> _abilities;
        private List<IAbility> _effects;

        public Wizard(string name, int hp, int strength)
            : base(name, hp, strength)
        {
            _abilities = new List<IAbility>() { new Attack(Strength), new Spellbinding() };
            _effects = new List<IAbility>();
        }

        public override void MakeAMove()
        {
            _isSkip = false;
            List<IAbility> effects = _effects;
            foreach (var effect in effects)
            {
                if (effect.IsSkipRound)
                {
                    _isSkip = true;
                    Logger.WriteLog($"{ToString()} is skipping step");
                }

                if (effect.IsFire)
                {
                    IsFire = true;
                    Logger.WriteLog($"{ToString()} is burning");
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
                if (effect.ActionDuration <= 0)
                {
                    _effects.Remove(effect);
                }

                if (_effects.Count <= 1)
                {
                    break;
                }
            }

            Logger.WriteLog($"{ToString()} has {Hp} HP");
            Logger.WriteLog("-------------------------------------------------------");

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
            Logger.WriteLog($"{ToString()} used {_abilities[randomIndex].Name} against {_enemy.ToString()}");
            _abilities[randomIndex].NumOfUses -= 1;
            if (_abilities[randomIndex].NumOfUses == 0)
            {
                Logger.WriteLog($"{ToString()} used maximum times of {_abilities[randomIndex].Name}");
                _abilities.RemoveAt(randomIndex);
            }
        }

        public override string ToString()
        {
            return $"Wizard: {Name}";
        }
    }
}