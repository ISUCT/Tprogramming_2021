namespace CourseApp
{
    using System;

    public class MagicDog : Dog
    {
        private int mana = 200;
        private int helth = 100;
        private int attack = 20;
        private int stamina = 100;

        public MagicDog(string name, int age, int weight, int mana, int helth, int attack, int stamina)
            : base(name, age, weight)
        {
            if (mana > 200)
            {
                this.mana = mana;
            }

            if (helth > 100)
            {
                this.helth = helth;
            }

            if (attack > 20)
            {
                this.attack = attack;
            }

            if (stamina > 100)
            {
                this.stamina = stamina;
            }
        }

        public string Attack(int strenght)
        {
            if (strenght * 5 > stamina)
            {
                return "I'm tried...";
            }
            else if (strenght * 3 > mana)
            {
                return "I need more mana";
            }

            stamina -= strenght * 5;
            mana -= strenght * 3;
            return "Deal " + Convert.ToString(strenght * 10);
        }

        public string Desh(int metrs)
        {
            if (metrs * 20 > stamina)
            {
                return "I'm tried...";
            }

            stamina -= metrs * 20;
            return $"Over come {metrs}m.";
        }

        public string GetHit(int strenght)
        {
            if (strenght * 10 > helth)
            {
                return "I'm die...";
            }

            helth -= strenght * 10;
            return $"Oh, I have {stamina * 10}HP left";
        }

        public new string GetAll()
        {
            string s = base.GetAll();
            return $"{base.GetAll()}|HP:{helth}|MANA:{mana}|Stamina:{stamina}|Attack:{attack}";
        }
    }
}
