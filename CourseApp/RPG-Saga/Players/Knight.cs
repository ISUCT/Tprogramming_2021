namespace CourseApp.RPG_Saga
{
    using CourseApp.RPG_Saga.Interfaces;

    public class Knight : Player
    {
        public Knight(string name, double health, double strenght, IAbility ability)
        {
            Name = name;
            RoleName = "Knight";
            Health = health;
            RecivedDamage = 0;
            Strenght = strenght;
            IsStunned = false;
            Ability = ability;
        }
    }
}
