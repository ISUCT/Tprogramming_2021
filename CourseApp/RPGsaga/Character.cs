namespace CourseApp.RPGsaga
{
    using System;
    using System.Collections.Generic;

    public abstract class Character
    {
        private Character enemy;

        public Character(string type, string name, int healthpoints, int strenght, List<Ability> abilities)
        {
            Type = type;
            Name = name;
            Healthpoints = healthpoints;
            MaxHealth = healthpoints;
            Strenght = strenght;
            this.Abilities = abilities;
            Buffs = new List<Buff>();
            Card = CardGenerator.GenerateCard(this);
            Dead = false;
        }

        public double Scale { get; private set; }

        public Card Card { get; private set; }

        public List<Buff> Buffs { get; private set; }

        public List<Ability> Abilities { get; private set; }

        public int Strenght { get; private set; }

        public int MaxHealth { get; private set; }

        public int Healthpoints { get; private set; }

        public string Name { get; private set; }

        public string Type { get; private set; }

        public bool Dead { get; private set; }

        public void Turn()
        {
            Scale = 1;
            bool flag = false;
            List<Buff> buffs = Buffs;
            foreach (Buff b in buffs)
            {
                if (b.SkeepStep)
                {
                    flag = true;
                }

                Healthpoints -= b.Damage;
                if (Healthpoints > MaxHealth)
                {
                    Healthpoints = MaxHealth;
                }

                if (Healthpoints <= 0)
                {
                    Dead = true;
                    Logs.AddLogRowDeath(enemy, this);
                    return;
                }

                b.Duration--;
                Scale += b.ScaleDamage;
                if (b.Duration == 0)
                {
                     Buffs.Remove(b);
                }
            }

            if (!flag)
            {
                UseAbility();
            }
            else
            {
                Card = CardGenerator.GenerateCard(this);
            }
        }

        public void GetAttack(int enemydamage, List<Buff> buffs)
        {
            Healthpoints -= enemydamage;
            if (Healthpoints > MaxHealth)
            {
                Healthpoints = MaxHealth;
            }

            if (Healthpoints <= 0)
            {
                Dead = true;
                Logs.AddLogRowDeath(enemy, this);
                return;
            }

            this.SetBuffs(buffs);
            Card = CardGenerator.GenerateCard(this);
        }

        public void SetEnemy(Character enemy)
        {
            this.enemy = enemy;
        }

        protected void UseAbility()
        {
            Random rnd = new Random();
            int random = rnd.Next(Abilities.Count);
            Ability ab = Abilities[random];
            if (ab.OnYourself)
            {
                this.GetAttack(ab.Damage, ab.GetBuffs());
                Logs.AddLogRowAbilityUse(this, this, ab);
            }
            else
            {
                enemy.GetAttack((int)(ab.Damage * (Strenght / 10) * Scale), ab.GetBuffs());
                Logs.AddLogRowAbilityUse(this, enemy, ab);
            }

            if (ab.Count > 0)
            {
                ab.Count--;
            }

            if (ab.Count == 0)
            {
                Abilities.Remove(ab);
            }

            Card = CardGenerator.GenerateCard(this);
        }

        private void SetBuffs(List<Buff> buffs)
        {
            Buff[] ab = new Buff[buffs.Count];
            buffs.CopyTo(ab);
            bool flag = true;
            foreach (Buff b in ab)
            {
                flag = true;
                foreach (Buff bb in Buffs)
                {
                    if (bb.Name.Equals(b.Name))
                    {
                        bb.Duration += b.Duration;
                        flag = false;
                    }
                }

                if (flag)
                {
                    Buffs.Add(b);
                }
            }
        }
    }
}
