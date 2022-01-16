namespace CourseApp.Zoo.Animals.Generators
{
    using System;
    using CourseApp.Zoo.Interfaces;

    public class RandomAnimalNameGenerator : IRandomNameGenerator
    {
        private readonly Random _random;

        private readonly string[] _name = new[]
        {
            "Sharik",
            "Atlas",
            "Vasya",
            "Barsik",
            "Tuzik",
            "Murka",
            "Busya",
            "Laika",
            "Snezhok",
            "Pushok",
            "Bobik",
            "Malish",
            "Mark :D",
            "Rizhik",
        };

        public RandomAnimalNameGenerator()
        {
            _random = new Random();
        }

        public string Generate()
        {
            return _name[_random.Next(0, _name.Length)];
        }
    }
}