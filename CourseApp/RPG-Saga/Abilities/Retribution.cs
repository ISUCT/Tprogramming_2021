namespace CourseApp.RPG_Saga.Abilities
{
    using CourseApp.RPG_Saga.Interfaces;
    using CourseApp.RPG_Saga.Logger_;

    public class Retribution : IAbility
    {
        public Retribution()
        {
            Name = "Retribution";
            Damage = 0;
            BasicDuration = 1;
            CurrentDuration = BasicDuration;
            IsUsed = false;
            IsAvailable = true;
        }

        public string Name { get; set; }

        public double Damage { get; set; }

        public int BasicDuration { get; set; }

        public int CurrentDuration { get; set; }

        public bool IsUsed { get; set; }

        public bool IsAvailable { get; set; }

        public void Cast(Player source, Player target)
        {
            if (CurrentDuration <= 0)
            {
                IsUsed = false;
                CurrentDuration = BasicDuration;
            }
            else
            {
                IsUsed = true;
                target.Health -= source.Strenght * 1.3;
                target.RecivedDamage += source.Strenght * 1.3;
                CurrentDuration -= 1;
                Logger.AbilityLog(source.Name, source.RoleName, target.Name, target.RoleName, Name, source.Strenght * 1.3);
            }
        }
    }
}
