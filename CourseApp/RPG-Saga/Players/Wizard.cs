namespace CourseApp.RPG_Saga
{
    using System.Collections.Generic;
    using CourseApp.RPG_Saga.Interfaces;

    public class Wizard : Player
    {
        public Wizard(string name, double health, double strenght, List<IAbility> ability)
        {
            Name = name;
            RoleName = "Wizard";
            Health = health;
            RecivedDamage = 0;
            Strenght = strenght;
            IsStunned = false;
            Abilities = ability;
            Effects = new List<IAbility>();
        }
    }
}
