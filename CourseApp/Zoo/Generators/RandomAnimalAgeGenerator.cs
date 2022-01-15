namespace CourseApp.Zoo.Animals.Generators
{
    using System;
    using CourseApp.Zoo.Interfaces;

    public class RandomAnimalAgeGenerator : IRandomAgeGenerator
    {
        private readonly Random _random;

        public RandomAnimalAgeGenerator()
        {
            _random = new Random();
        }

        public int Generate()
        {
            return _random.Next(0, 20);
        }
    }
}