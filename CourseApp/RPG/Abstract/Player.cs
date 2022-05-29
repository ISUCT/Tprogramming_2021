namespace CourseApp
{
    public abstract class Player : IPlayer
    {
        public Player(string name, double health, int strength)
        {
            Name = name;
            Health = health;
            Strength = strength;
            EffectAbility = false;
            Afk = 0;
            PrimalHealth = health;
        }

        public int Afk { get; set; }

        public double Health { get; set; }

        public double PrimalHealth { get; set; }

        public int Strength { get; set; }

        public string Name { get; set; }

        public string NameUlt { get; set; }

        public int DamageUlt { get; set; }

        public int InfoDamage { get; set; }

        public string ClassHero { get; set; }

        public bool EffectAbility { get; set; }

        public virtual int Ultimate(Player unit, Player rival)
        {
            return 0;
        }

        public int AttackingUnit(Player unit, Player unitRival)
        {
            if (unit.EffectAbility)
            {
                unit.EffectAbility = false;
                return InfoDamage = unit.Ultimate(unit, unitRival);
            }
            else
            {
                return InfoDamage = Strength;
            }
        }

        public int AttackingRival(Player unit, Player unitRival)
        {
            if (unitRival.EffectAbility)
            {
                unitRival.EffectAbility = false;
                return InfoDamage = unitRival.Ultimate(unit, unitRival);
            }
            else
            {
                return InfoDamage = Strength;
            }
        }

        public void GetDamage(int damage)
        {
            Health -= damage;
        }

        public void ResetHealth()
        {
            Health = PrimalHealth;
        }

        public virtual string InfoOutput()
        {
            return $"Имя юнита: {Name} ; Здоровье юнита: {Health} ; Сила юнита: {Strength}";
        }
    }
}