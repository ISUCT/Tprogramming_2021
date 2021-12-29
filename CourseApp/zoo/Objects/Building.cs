namespace CourseApp
{
    using System;
    using CourseApp.Interfaces;

    public class Building : Staff, IDrawable
    {
        public Building(string designation, string type, string material, string location)
            : base(designation, type, material)
        {
            Designation = designation;
            Type = type;
            Material = material;
            Location = location;
        }

        public string Location { get; set; }

        public string Draw()
        {
            var inform = @$"Объект
Наименование: {Designation}
Тип: {Type}
Материал: {Material}
Месторасположение: {Location}";
            Console.WriteLine(inform);
            return " ";
        }
    }
}