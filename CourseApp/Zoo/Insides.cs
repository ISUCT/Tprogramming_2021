namespace CourseApp
{
    using System;
    using System.Collections.Generic;
    using CourseApp.Interfaces;

    public class Insides : IDrawable
    {
        public Insides(string name)
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
            list.Add(new Dog("Боня", "Средний", 4, 1, "Женский", "Корги"));
            list.Add(new Dog("Веста", "Большая", 2, 6, "Женский", "Терьер"));
            list.Add(new Bird("Пеликан", "Средний", 2, 1, "Мужской", "Хищник"));
            list.Add(new Bird("Орел", "Большой", 4, 2, "Мужской", "Хищник"));
            list.Add(new Lion("Симба", "Средненькая", 78, 3, "Женский"));
            list.Add(new Clovenhoofed("Тиша", "Огромный", 150, 7, "Женский", "Закругленные"));
            return list;
        }

        public List<IDrawable> Peoples()
        {
            var list = new List<IDrawable>();
            list.Add(new Employee("Алексей", 19, "Мужской", "Уборщик", 19500));
            list.Add(new Employee("Марк", 41, "Мужской", "Гид", 35000));
            list.Add(new Guest("Марта", 20, "Женский"));
            list.Add(new Guest("Виолета", 32, "Женский"));
            return list;
        }

        public List<IDrawable> Objects()
        {
            var list = new List<IDrawable>();
            list.Add(new Decor("Арка", "Белый", "Кирпич", "Красиво смотрится при входе", 150000));
            list.Add(new Decor("Фонтан", "Бирюзовый", "Камни", "Успокаивает", 2000000));
            list.Add(new Safety("Клетка", "Серый", "Металл", "Не дает подопечным съесть посетителей"));
            list.Add(new Safety("Тазер", "Чёрный", "Пластмасса", "Защищает от потенциальных дебоширов"));
            return list;
        }
    }
}