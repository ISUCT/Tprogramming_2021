namespace CourseApp.RPGSaga.Generators
{
    using System;
    using System.Collections.Generic;
    using CourseApp.RPGSaga.Heroes;

    public class PlayerFabric : Fabric
    {
        private List<string> _name = new List<string>()
        {
            "Артемий", "Ева", "Кира", "Платон", "Максим", "Владимир", "Алиса", "Василий", "София", "Ника", "Марьям",
            "Тимофей", "Ангелина", "Мирон", "Антон", "Ярослав", "Иван", "Аделина", "Валерия", "Диана", "Дмитрий",
            "Амина", "Алексей", "Кирилл", "Александр", "Даниил", "Агата", "Виктория", "Михаил", "Злата", "Илья",
            "Дарья", "Ксения",
        };

        private List<string> _heroesTypes = new List<string>() { "Archer", "Knight", "Wizard" };

        public override Player FactoryMethod()
        {
            return CreatePlayer();
        }

        private string SetName()
        {
            return _name[Random.Shared.Next(0, _name.Count)];
        }

        private int SetHP()
        {
            return Random.Shared.Next(70, 100);
        }

        private int SetStrength()
        {
            return Random.Shared.Next(10, 15);
        }

        private Player CreatePlayer()
        {
            Player hero = null;
            switch (_heroesTypes[Random.Shared.Next(0, _heroesTypes.Count)])
            {
                case "Archer":
                    hero = new Archer(SetName(), SetHP(), SetStrength());
                    break;
                case "Knight":
                    hero = new Knight(SetName(), SetHP(), SetStrength());
                    break;
                case "Wizard":
                    hero = new Wizard(SetName(), SetHP(), SetStrength());
                    break;
            }

            return hero;
        }
    }
}