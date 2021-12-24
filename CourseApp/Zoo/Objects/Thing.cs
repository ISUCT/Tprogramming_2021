namespace CourseApp
{
    using System;
    using CourseApp.Interfaces;

    public class Thing : Staff, IDrawable
    {
        public Thing(string role, string size, string material)
            : base(role, size, material)
        {
            Role = role;
            Size = size;
            Material = material;
        }

        public string Draw()
        {
            var inform = @$"Вещь
Название: {Role}
Размер: {Size}
Материал: {Material}";
            Console.WriteLine(inform);
            return " ";
        }
    }
}
