namespace CourseApp.RPGsaga
{
    public class FreezeRay : Ability
    {
        public FreezeRay()
        {
            Type = "Mag";
            Name = "FreezeRay";
            Damage = 10;
            Count = 5;
            OnYourself = false;
            AddBuff(new Freeze());
        }
    }
}
