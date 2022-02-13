namespace CourseApp
{
    using System;
    using CourseApp.Interfaces;

    public class Decor : Staff, IDrawable
    {
        public Decor(string title, string color, string material, string mission, int price)
            : base(title, color, material, mission)
        {
            Title = title;
            Color = color;
            Material = material;
            Mission = mission;
            Price = price;
        }

        public int Price { get; set; }

        public string Draw()
        {
            var inform = @$"Декор
Название: {Title}
Цвет: {Color}
Материал: {Material}
Предназначение: {Mission}
Цена: {Price}";
            Console.WriteLine(inform);
            return " ";
        }
    }
}