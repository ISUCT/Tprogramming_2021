namespace CourseApp.RPGsaga
{
    using System.Collections.Generic;

    public class Archer : Character
    {
        public Archer(string name, List<Ability> ab)
            : base("Archer", name, 150, 20, ab)
        {
        }
    }
}
