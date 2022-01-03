namespace CourseApp {
    using System;
    using CourseApp.Interfaces;

    public class Thing : Staff, IDrawable {
        public Thing(string role, string material, string size)
            : base(role, material, size)
        {
            Role = role;
            Material = material;
            Size = size;
        }

        public string Draw() {
            var inform = @$"Вещь
            Название: {Role}
            Материал: {Material}
            Размер: {Size}
            ";
            Console.WriteLine(inform);
            return " ";
        }
    }
}
