namespace CourseApp.RPG_Saga
{
    using System.Collections.Generic;
    using CourseApp.RPG_Saga.Interfaces;

    public class Knight : Player
    {
        public Knight(string name, double health, double strenght, List<IAbility> abilities)
        {
            Name = name;
            RoleName = "Knight";
            Health = health;
            RecivedDamage = 0;
            Strenght = strenght;
            IsStunned = false;
            Abilities = abilities;
            Effects = new List<IAbility>();
        }
    }
}
