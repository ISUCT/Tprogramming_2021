namespace CourseApp.RPGsaga
{
    using System.Collections.Generic;

    public class Mag : Character
    {
        public Mag(string name, List<Ability> ab)
            : base("Mag", name, 100, 15, ab)
        {
        }
    }
}
