namespace CourseApp.RPGsaga
{
    public class MaglFAr : Ability
    {
        public MaglFAr()
        {
            Type = "Mag";
            Name = "MagicalFireArrow";
            Damage = 5;
            OnYourself = false;
            Count = 3;
            AddBuff(new Burn());
            AddBuff(new Burn());
        }
    }
}
