namespace CourseApp.RPGsaga
{
    public class Sword : Ability
    {
        public Sword()
        {
            Name = "Sword";
            Type = "Knight";
            OnYourself = false;
            Count = -1;
            Damage = 20;
            AddBuff(new Bleading());
        }
    }
}
