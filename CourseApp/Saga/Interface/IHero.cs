namespace CourseApp
{
    public interface IHero
    {
        string Name { get; set; }

        double Health { get; set; }

        double Damage { get; set; }

        double Stamina { get; set; }

        public bool Dead { get; set; }

        double StartHealth { get; set; }
    }
}