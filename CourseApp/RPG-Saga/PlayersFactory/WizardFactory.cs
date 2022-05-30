namespace CourseApp.RPG_Saga.PlayersFactory
{
    using System;
    using System.Collections.Generic;
    using CourseApp.RPG_Saga.Abilities;
    using CourseApp.RPG_Saga.Interfaces;

    public class WizardFactory : PlayersFactory
    {
        public override Player GetPlayer(string name)
        {
            Random rnd = new Random();
            List<IAbility> abilities = new List<IAbility>();
            abilities.Add(new Freezing());

            return new Wizard(name, rnd.Next(80, 90), rnd.Next(10, 15), abilities);
        }
    }
}
