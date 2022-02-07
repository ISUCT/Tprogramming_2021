namespace CourseApp.RPGsaga
{
    public abstract class Buff
    {
        public Buff(string type, string name, double scale, int damge, bool sP, int dur)
        {
            Type = type;
            Name = name;
            Damage = damge;
            ScaleDamage = scale;
            SkeepStep = sP;
            Duration = dur;
        }

        public double ScaleDamage { get; set; }

        public string Type { get; set; }

        public string Name { get; set; }

        public int Damage { get; set; }

        public bool SkeepStep { get; set; }

        public int Duration { get; set; }
    }
}
