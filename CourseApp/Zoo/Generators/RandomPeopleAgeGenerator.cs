namespace CourseApp.Zoo.People.Generators
{
    using System;
    using CourseApp.Zoo.Interfaces;

    public class RandomPeopleAgeGenerator : IRandomAgeGenerator
    {
        private readonly Random _random;

        public RandomPeopleAgeGenerator()
        {
            _random = new Random();
        }

        public int Generate()
        {
            return _random.Next(0, 100);
        }
    }
}