namespace CourseApp.RPG_Saga
{
    using CourseApp.RPG_Saga.Interfaces;
    using CourseApp.RPG_Saga.Logger_;

    public abstract class Player
    {
        public string Name { get; set; }

        public string RoleName { get; set; }

        public double Health { get; set; }

        public double RecivedDamage { get; set; }

        public double Strenght { get; set; }

        public bool IsStunned { get; set; }

        public IAbility Ability { get; set; }

        public void ApplyDamage(Player player)
        {
            player.Health -= Strenght;
            player.RecivedDamage += Strenght;
            Logger.DamageLog(Name, RoleName, player.Name, player.RoleName, Strenght);
        }

        public void UseAbility(Player source, Player target)
        {
            Ability.Cast(source, target);
        }

        public void Reset()
        {
            Health += RecivedDamage;
            IsStunned = false;
            Ability.IsAvailable = true;
            Ability.IsUsed = false;
            Ability.CurrentDuration = Ability.BasicDuration;
        }
    }
}
