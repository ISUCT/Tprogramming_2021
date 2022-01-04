namespace CourseApp {
    using System;
    using CourseApp.Interfaces;

    public class Building : Staff, IDrawable {
        public Building(string role, string size, string material, string location)
            : base(role, size, material)
        {
            Role = role;
            Size = size;
            Material = material;
            Location = location;
        }

        public string Location { get; set; }

        public string Draw() {
            var inform = @$"Объект
            Название: {Role}
            Размер: {Size}
            Материал: {Material}
            Месторасположение: {Location}";
            Console.WriteLine(inform);
            return " ";
        }
    }
}
