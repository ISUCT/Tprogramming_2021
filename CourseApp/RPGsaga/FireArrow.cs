namespace CourseApp.RPGsaga
{
    public class FireArrow : Ability
    {
        public FireArrow()
        {
            Type = "Archer";
            Name = "FireArrow";
            Damage = 5;
            OnYourself = false;
            Count = 2;
            AddBuff(new Burn());
        }
    }
}
