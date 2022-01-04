namespace CourseApp {
    using System;
    using System.Collections.Generic;
    using CourseApp.Interfaces;

    public class ZoologicalGarden : IDrawable {
        public ZoologicalGarden(string name) {
            Name = name;
        }

        public string Name { get; set; }

        public string Draw() {
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

        public List<IDrawable> Animals() {
            var list = new List<IDrawable>();
            list.Add(new Dolphin("Килька", "Биг", 3, "Жен"));
            list.Add(new Dolphin("Фонтанчик", "Мини", 1, "Муж"));
            list.Add(new Horse("Богдан", "Очень-большой", 3, "Муж", "Серый"));
            list.Add(new Wolf("Серушка", "Средняя", 2, "Жен", "Серый"));
            list.Add(new Wolf("Темныш", "Большой", 3, "Муж", "Черный"));
            return list;
        }

        public List<IDrawable> Objects() {
            var list = new List<IDrawable>();
            list.Add(new Thing("Тантамареска", "картон", "1,5 х 1 м"));
            list.Add(new Thing("Лавочка", "Дерево", "2 х 1 x 1 м"));
            list.Add(new Building("Кафе", "Огромный", "Земля", "Недалеко от смотровой площадки"));
            list.Add(new Building("Тубзик", "Мега-огромный", "Камни", "Рядом с картой"));
            list.Add(new Building("Забор", "Большой", "Из железных прутьев", "По всему периметру"));
            return list;
        }

        public List<IDrawable> Peoples() {
            var list = new List<IDrawable>();
            list.Add(new Guest("Бубончик", 33));
            list.Add(new Guest("Полька", 12));
            list.Add(new Worker("Петрович", "Уборщик", 18));
            list.Add(new Worker("Василий", "Охранник", 43));
            return list;
        }

        
    }
}