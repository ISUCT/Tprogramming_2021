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
            list.Add(new Tiger("Шар-Хан", "Большой", 3, "Мальчик", "Амурский"));
            list.Add(new Fish("Карасик", "Средний", 1, "Мальчик"));
            list.Add(new Fish("Оскар", "Маленький", 2, "Мальчик"));
            list.Add(new Lion("Симба", "Большой", 3, "Мальчик", "Большая"));
            list.Add(new Lion("Нала", "Маленький", 3, "Девочка", "Маленькая"));
            return list;
        }

        public List<IDrawable> Peoples()
        {
            var list = new List<IDrawable>();
            list.Add(new Person("Максим", "Уборщик", 21));
            list.Add(new Person("Денис", "Охранник", 35));
            list.Add(new Guest("Дмитрий", 18));
            list.Add(new Guest("Ксюша", 16));
            return list;
        }

        public List<IDrawable> Objects()
        {
            var list = new List<IDrawable>();
            list.Add(new Building("MacDonalds", "Средний", "Бетон", "Рядом с главными воротами"));
            list.Add(new Building("Забор", "Большой", "Железные прутья", "По всему периметру"));
             list.Add(new Building("Туалет", "Мега-огромный", "Бетон", "Около кафе MacDonalds"));
            list.Add(new Thing("Автомат с сувенирами", "0,5 х 0,5 х 1 м", "Металл и стекло"));
            list.Add(new Thing("Карта", "1 х 1 м", "Бумага"));
            return list;
        }
    }
}