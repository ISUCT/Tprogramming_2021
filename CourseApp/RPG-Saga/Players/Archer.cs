namespace CourseApp.RPG_Saga
{
    using CourseApp.RPG_Saga.Interfaces;

    public class Archer : Player
    {
        public Archer(string name, double health, double strenght, IAbility ability)
        {
            Name = name;
            RoleName = "Archer";
            Health = health;
            RecivedDamage = 0;
            Strenght = strenght;
            IsStunned = false;
            Ability = ability;
        }
    }
}
