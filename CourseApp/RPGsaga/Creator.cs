namespace CourseApp.RPGsaga
{
    using System;

    public static class Creator
    {
        public static Character CreateCharacter(string type)
        {
            string[] names = { "Karl", "Jhon", "Edward", "Troll", "Chain", "Kobra", "Ludvig", "Zelda", "Mario" };
            Random rnd = new Random();

            string name;
            name = names[rnd.Next(names.Length)];
            return CreateCharacter(type, name);
        }

        public static Character CreateCharacter(string type, string name)
        {
            switch (type)
            {
                case "Mag":
                    return CreateMag(name);
                case "Knight":
                    return CreateKnight(name);
                default:
                    return CreateArcher(name);
            }
        }

        private static Mag CreateMag(string name)
        {
            AbCreator creator = new AbCreator();
            return new Mag(name, creator.GetAbilities("Mag"));
        }

        private static Knight CreateKnight(string name)
        {
            AbCreator creator = new AbCreator();
            return new Knight(name, creator.GetAbilities("Knight"));
        }

        private static Archer CreateArcher(string name)
        {
            AbCreator creator = new AbCreator();
            return new Archer(name, creator.GetAbilities("Archer"));
        }
    }
}
