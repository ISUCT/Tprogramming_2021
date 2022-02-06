namespace CourseApp.RPGsaga
{
    public class ExtraHeal : Ability
    {
        public ExtraHeal()
        {
            Type = "Mag";
            Name = "ExtraHeal";
            Damage = -50;
            OnYourself = true;
            Count = 1;
            AddBuff(new Healing());
        }
    }
}
