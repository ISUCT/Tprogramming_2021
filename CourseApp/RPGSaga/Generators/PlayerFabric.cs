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

        private Player CreatePlayer()
        {
            Player hero = null;
            switch (_heroesTypes[Random.Shared.Next(0, _heroesTypes.Count)])
            {
                case "Archer":
                    hero = new Archer(_name[Random.Shared.Next(0, _name.Count)], 95, 14);
                    break;
                case "Knight":
                    hero = new Knight(_name[Random.Shared.Next(0, _name.Count)], 90, 15);
                    break;
                case "Wizard":
                    hero = new Wizard(_name[Random.Shared.Next(0, _name.Count)], 100, 13);
                    break;
            }

            return hero;
        }
    }
}