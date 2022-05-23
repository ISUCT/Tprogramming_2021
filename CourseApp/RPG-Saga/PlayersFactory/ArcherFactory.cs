namespace CourseApp.RPG_Saga.PlayersFactory
{
    using System;
    using CourseApp.RPG_Saga.Abilities;

    public class ArcherFactory : PlayersFactory
    {
        public override Player GetPlayer(string name)
        {
            Random rnd = new Random();
            return new Archer(name, rnd.Next(90, 100), rnd.Next(15, 25), new FlamingArrows());
        }
    }
}
