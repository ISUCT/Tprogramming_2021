namespace CourseApp.RPGsaga
{
    public class FireBall : Ability
    {
        public FireBall()
        {
            Name = "FireBall";
            Type = "Mag";
            Damage = 30;
            OnYourself = false;
            Count = 1;
            AddBuff(new Burn());
            AddBuff(new Burn());
        }
    }
}
