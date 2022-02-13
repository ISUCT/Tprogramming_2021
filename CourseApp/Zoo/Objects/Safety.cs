namespace CourseApp
{
    using System;
    using CourseApp.Interfaces;

    public class Safety : Staff, IDrawable
    {
        public Safety(string title, string color, string material, string mission)
            : base(title, color, material, mission)
        {
            Title = title;
            Color = color;
            Material = material;
            Mission = mission;
        }

        public string Draw()
        {
            var inform = @$"Объекты безопасности
Название: {Title}
Размер: {Color}
Материал: {Material}
Предназначение {Mission}";
            Console.WriteLine(inform);
            return " ";
        }
    }
}