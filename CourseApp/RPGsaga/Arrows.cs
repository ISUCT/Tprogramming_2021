namespace CourseApp.RPGsaga
{
    public class Arrows : Ability
    {
        public Arrows()
        {
            Name = "Arrows";
            Type = "Archer";
            Damage = 25;
            OnYourself = false;
            Count = -1;
        }
    }
}
