namespace CourseApp.RPGsaga
{
    using System.Collections.Generic;

    public abstract class Ability
    {
        private List<Buff> buffs = new List<Buff>();

        public Ability()
        {
        }

        public string Type { get; set; }

        public string Name { get; set; }

        public bool OnYourself { get; set; }

        public int Damage { get; set; }

        public int Count { get; set; }

        public List<Buff> GetBuffs()
        {
            return buffs;
        }

        protected void AddBuff(Buff buff)
        {
            this.buffs.Add(buff);
        }
    }
}
