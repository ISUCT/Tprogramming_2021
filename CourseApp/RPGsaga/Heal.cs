namespace CourseApp.RPGsaga
{
    public class Heal : Ability
    {
        public Heal()
        {
            Name = "Heal";
            Type = "Mag";
            OnYourself = true;
            Count = 2;
            Damage = -20;
        }
    }
}
