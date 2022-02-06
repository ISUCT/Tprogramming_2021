namespace CourseApp.RPGsaga
{
    public class Revenge : Ability
    {
        public Revenge()
        {
            Name = "Revenge";
            Type = "Knight";
            OnYourself = true;
            Damage = 0;
            Count = 1;
            AddBuff(new Rev());
        }
    }
}
