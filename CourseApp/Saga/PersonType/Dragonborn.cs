namespace CourseApp
{
    using System;
    using CourseApp.Saga.Abilities;
    using CourseApp.Saga.Interface;

    public class Dragonborn : Hero
    {
        public Dragonborn(string name, double health, int damage, double stamina)
        : base(name, health, damage, stamina)
        {
            Class = "Драконорожденный";
            PrimaryName = "Голос Дракона";
        }
        public override int Primary(Hero fighter, Hero opp)
        {
            if (Ulta.IsFire)
                {
                    IsFire = true;
                    Logger.WriteLog($"{ToString()} is burning");
                }
        }
    }
}