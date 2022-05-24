namespace CourseApp.RPG_Saga.Abilities
{
    using CourseApp.RPG_Saga.Interfaces;
    using CourseApp.RPG_Saga.Logger_;

    public class Freezing : IAbility
    {
        public Freezing()
        {
            Name = "Freezing";
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
                target.IsStunned = false;
                IsUsed = false;
                CurrentDuration = BasicDuration;
            }
            else
            {
                IsUsed = true;
                target.IsStunned = true;
                target.Health -= Damage;
                target.RecivedDamage += Damage;
                CurrentDuration -= 1;
                Logger.AbilityLog(source.Name, source.RoleName, target.Name, target.RoleName, Name, Damage);
                source.ApplyDamage(target);
            }
        }
    }
}
