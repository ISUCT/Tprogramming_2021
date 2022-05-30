namespace CourseApp.RPG_Saga.GameLogic
{
    using System;
    using System.Collections.Generic;
    using CourseApp.RPG_Saga.PlayersFactory;

    public abstract class Generator
    {
        private static List<string> namesList = new List<string>() { "Tom", "Liam", "Noah", "Oliver", "Elijah", "James", "William", "Benjamin", "Lucas", "Henry", "Theodore", "Olivia", "Emma", "Charlotte", "Amelia", "Ava", "Sophia", "Isabella", "Mia", "Evelyn", "Harper" };

        private static List<string> rolesList = new List<string>() { "Archer", "Knight", "Wizard" };

        public static Player Generate()
        {
            string name;
            string role;
            Random rnd = new Random();
            PlayersFactory factory;

            name = namesList[rnd.Next(0, namesList.Count)];
            role = rolesList[rnd.Next(0, rolesList.Count)];

            switch (role)
            {
                case "Archer":
                    factory = new ArcherFactory();
                    return factory.GetPlayer(name);

                case "Knight":
                    factory = new KnightFactory();
                    return factory.GetPlayer(name);

                case "Wizard":
                    factory = new WizardFactory();
                    return factory.GetPlayer(name);
                default:
                    return null;
            }
        }
    }
}