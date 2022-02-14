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
            // Сделать через emum
            Player hero = null;
            var name = _name[Random.Shared.Next(0, _name.Count)];
            var healthpoints = Random.Shared.Next(80, 100);
            var strength = Random.Shared.Next(20, 30);
            switch (_heroesTypes[Random.Shared.Next(0, _heroesTypes.Count)])
            {
                case "Archer":
                    hero = new Archer(name, healthpoints, strength);
                    break;
                case "Knight":
                    hero = new Knight(name, healthpoints, strength);
                    break;
                case "Wizard":
                    hero = new Wizard(name, healthpoints, strength);
                    break;
            }

            return hero;
        }
    }
}