namespace CourseApp.RPG_Saga.PlayersFactory
{
    using System;
    using CourseApp.RPG_Saga.Abilities;

    public class WizardFactory : PlayersFactory
    {
        public override Player GetPlayer(string name)
        {
            Random rnd = new Random();
            return new Wizard(name, rnd.Next(80, 90), rnd.Next(10, 15), new Freezing());
        }
    }
}
