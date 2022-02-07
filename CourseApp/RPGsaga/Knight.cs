namespace CourseApp.RPGsaga
{
    using System.Collections.Generic;

    public class Knight : Character
    {
        public Knight(string name, List<Ability> abilities)
            : base("Knight", name, 200, 30, abilities)
        {
        }
    }
}
