namespace CourseApp.Zoo.Generators
{
    using System;
    using CourseApp.Zoo.Interfaces;

    public class RandomPeopleNameGenerator : IRandomNameGenerator
    {
        private readonly Random _random;

        private readonly string[] _name = new[]
        {
            "Mikey",
            "Shayne",
            "Vladimir",
            "Kolya",
            "Aleksei",
            "Mark",
            "Eugene",
            "Maksim",
            "Varvara",
            "Anastasiya",
            "Kristina",
            "Aleksandr",
            "Olya",
            "Sofa",
        };

        public RandomPeopleNameGenerator()
        {
            _random = new Random();
        }

        public string Generate()
        {
            return _name[_random.Next(0, _name.Length)];
        }
    }
}