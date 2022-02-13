namespace CourseApp
{
    using System;

    public abstract class Hero : IHero
    {
        public Hero(string name, double health, int damage, double stamina)
        {
            Name = name;
            Health = health;
            Damage = damage;
            StartHealth = health;
            Ulta = false;
        }

        public string Class { get; set; }

        public string Name { get; set; }

        public int HitInf { get; set; }

        public int Damage { get; set; }

        public double StartHealth { get; set; }

        public bool Ulta { get; set; }

        public string PrimaryName { get; set; }

        public int PrimaryDamage { get; set; }

        public double Health { get; set; }

        public double Stamina { get; set; }

        public virtual int Primary(Hero player, Hero opp)
            {
                return 0;
            }

        public int FighterAttack(Hero fighter, Hero fighterOpp)
        {
            if (fighter.Ulta)
            {
                fighter.Ulta = false;
                return HitInf = fighter.Primary(fighter, fighterOpp);
            }
            else
            {
                return HitInf = Damage;
            }
        }

        public int OppAttack(Hero fighter, Hero fighterOpp)
        {
            if (fighter.Ulta)
            {
                fighter.Ulta = false;
                return HitInf = fighter.Primary(fighter, fighterOpp);
            }
            else
            {
                return HitInf = Damage;
            }
        }

        public virtual string InfoOutput()
        {
            return $"Имя: {Name} ; Здоровье: {Health} ; Сила: {Damage} ; Выносливость: {Stamina}";
        }

        public void GetHit(int hit)
        {
            Health -= hit;
        }

        public void ResetHealth()
        {
            Health = StartHealth;
        }
    }
}
