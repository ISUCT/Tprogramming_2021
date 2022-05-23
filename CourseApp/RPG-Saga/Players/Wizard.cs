namespace CourseApp.RPG_Saga
{
    using CourseApp.RPG_Saga.Interfaces;

    public class Wizard : Player
    {
        public Wizard(string name, double health, double strenght, IAbility ability)
        {
            Name = name;
            RoleName = "Wizard";
            Health = health;
            RecivedDamage = 0;
            Strenght = strenght;
            IsStunned = false;
            Ability = ability;
        }
    }
}
