namespace CourseApp.RPG_Saga.PlayersFactory
{
    using System;
    using System.Collections.Generic;
    using CourseApp.RPG_Saga.Abilities;
    using CourseApp.RPG_Saga.Interfaces;

    public class KnightFactory : PlayersFactory
    {
        public override Player GetPlayer(string name)
        {
            Random rnd = new Random();
            double strenght = rnd.Next(15, 20);
            List<IAbility> abilities = new List<IAbility>();
            abilities.Add(new Retribution(strenght));

            return new Knight(name, rnd.Next(100, 110), strenght, abilities);
        }
    }
}
