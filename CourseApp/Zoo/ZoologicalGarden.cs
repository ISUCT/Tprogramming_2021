namespace CourseApp
{
    using System;
    using System.Collections.Generic;
    using CourseApp.Interfaces;

    public class ZoologicalGarden : IDrawable
    {
        public ZoologicalGarden(string name)
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
            Console.WriteLine($"Человеки:\n");
            user.Draw(Peoples());
            Console.WriteLine($"Объекты:\n");
            user.Draw(Objects());
            return " ";
        }

        public List<IDrawable> Animals()
        {
            var list = new List<IDrawable>();
            list.Add(new Dog("Тузик", "Маленький", 3, "Мальчик", "Немецкая овчарка"));
            list.Add(new Dog("Джесси", "Большая", 2, "Девотька", "Стафорд"));
            list.Add(new Fish("Дори", "Малюсенькая", 1, "Девчуля"));
            list.Add(new Fish("Немо", "Козявка", 2, "Пацанчик"));
            list.Add(new Unicorn("Пинки Пай", "Средненькая", 3, "Женский", "Радужная"));
            return list;
        }

        public List<IDrawable> Peoples()
        {
            var list = new List<IDrawable>();
            list.Add(new Person("Ярик", "Пхп программист", 16));
            list.Add(new Person("Ваван", "Охранник", 32));
            list.Add(new Guest("Андуджбал", 27));
            list.Add(new Guest("Милана", 5));
            return list;
        }

        public List<IDrawable> Objects()
        {
            var list = new List<IDrawable>();
            list.Add(new Building("Кыэфси", "Огромный", "Земля", "Недалеко от смотровой площадки"));
            list.Add(new Building("Тубзик", "Мега-огромный", "Камни", "Рядом с картой"));
            list.Add(new Building("Забор", "Большой", "Из железных прутьев", "По всему периметру"));
            list.Add(new Thing("Автомат газировки", "0,5 х 0,5 х 1 м", "Металл и стекло"));
            list.Add(new Thing("Карта", "1 х 1 м", "Бумага"));
            return list;
        }
    }
}