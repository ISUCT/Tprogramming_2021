namespace CourseApp
{
    using System;
    using System.Collections.Generic;
    using CourseApp.Interfaces;

    public class ZooNatural : IDrawable
    {
        public ZooNatural(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public string Draw()
        {
            var user = new UserInterface();
            Console.WriteLine($"Зоопарк {Name}");
            Console.WriteLine($"Животные:\n");
            user.Draw(Animals());
            Console.WriteLine($"Люди:\n");
            user.Draw(Peoples());
            Console.WriteLine($"Объекты:\n");
            user.Draw(Objects());
            return " ";
        }

        public List<IDrawable> Animals()
        {
            var list = new List<IDrawable>();
            list.Add(new Lion("Слабый", "Большой", 5, "Мальчик", "Барбарийский лев"));
            list.Add(new Lion("Сильный", "Большой", 2, "Мальчик", "Западо-африканский лев"));
            list.Add(new Fish("Немо", "Маленькая ", 2, "-"));
            list.Add(new Bird("Гриша", "Маленькая", 1, "Женский", "Красно-зеленая"));
            return list;
        }

        public List<IDrawable> Peoples()
        {
            var list = new List<IDrawable>();
            list.Add(new Person("Максим", "Уборщик", 20));
            list.Add(new Person("Миша", "Охранник", 52));
            list.Add(new Visitor("Артем", 13));
            list.Add(new Visitor("Полина", 21));
            return list;
        }

        public List<IDrawable> Objects()
        {
            var list = new List<IDrawable>();
            list.Add(new Building("Клетка для животных", "Клетка створчатая", "Металл", "По всему зоопарку"));
            list.Add(new Building("Туалет", "Туалет человеческий", "Пластик", "В нескольких точках"));
            list.Add(new Building("Забор", "Забор металлический", "Металл", "По всему периметру"));
            list.Add(new Thing("Общепит", "-", "Железо-бетонная сооружение"));
            return list;
        }
    }
} 