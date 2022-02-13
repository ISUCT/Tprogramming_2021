namespace CourseApp
{
    public interface IHero
    {
        string Name { get; set; }

        double Health { get; set; }

        int Damage { get; set; }

        double Stamina { get; set; }

        double StartHealth { get; set; }
    }
}