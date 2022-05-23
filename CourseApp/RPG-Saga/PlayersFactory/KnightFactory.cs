namespace CourseApp.RPG_Saga.PlayersFactory
{
    using System;
    using CourseApp.RPG_Saga.Abilities;

    public class KnightFactory : PlayersFactory
    {
        public override Player GetPlayer(string name)
        {
            Random rnd = new Random();
            return new Knight(name, rnd.Next(100, 110), rnd.Next(15, 20), new Retribution());
        }
    }
}
