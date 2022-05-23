namespace CourseApp.RPG_Saga.Abilities
{
    using CourseApp.RPG_Saga.Interfaces;
    using CourseApp.RPG_Saga.Logger_;

    public class FlamingArrows : IAbility
    {
        public FlamingArrows()
        {
            Name = "FlamingArrows";
            Damage = 2.0;
            BasicDuration = 100;
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
            IsUsed = true;
            target.Health -= Damage;
            target.RecivedDamage += Damage;
            Logger.AbilityLog(source.Name, source.RoleName, target.Name, target.RoleName, Name, Damage);
        }
    }
}
