namespace CourseApp.RPG_Saga.PlayersFactory
{
    using System;
    using System.Collections.Generic;
    using CourseApp.RPG_Saga.Abilities;
    using CourseApp.RPG_Saga.Interfaces;

    public class ArcherFactory : PlayersFactory
    {
        public override Player GetPlayer(string name)
        {
            Random rnd = new Random();
            List<IAbility> abilities = new List<IAbility>();
            abilities.Add(new FlamingArrows());

            return new Archer(name, rnd.Next(90, 100), rnd.Next(15, 25), abilities);
        }
    }
}
