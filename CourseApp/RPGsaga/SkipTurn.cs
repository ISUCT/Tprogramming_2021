namespace CourseApp.RPGsaga
{
    public class SkipTurn : Ability
    {
        public SkipTurn()
        {
            Name = "SkipTurn";
            Type = "Mag";
            Damage = 0;
            OnYourself = false;
            Count = 1;
            AddBuff(new SkipT());
        }
    }
}
