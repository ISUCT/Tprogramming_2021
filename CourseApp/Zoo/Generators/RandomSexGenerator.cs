namespace CourseApp.Zoo.Generators
{
    using System;
    using CourseApp.Zoo.Interfaces;

    public class RandomSexGenerator : IRandomSexGenerator
    {
        private readonly Random _random;
        private readonly string[] _sex = new[]
        {
            "Female",
            "Male",
        };

        public RandomSexGenerator()
        {
            _random = new Random();
        }

        public string Generate()
        {
            return _sex[_random.Next(0, 2)];
        }
    }
}