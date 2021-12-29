namespace CourseApp
{
    using System;
    using CourseApp.Interfaces;

    public class Thing : Staff, IDrawable
    {
        public Thing(string designation, string type, string material)
            : base(designation, type, material)
        {
            Designation = designation;
            Type = type;
            Material = material;
        }

        public string Draw()
        {
            var inform = @$"Вещь
Наименование: {Designation}
Тип: {Type}
Материал: {Material}";
            Console.WriteLine(inform);
            return " ";
        }
    }
}