namespace CourseApp.Zoo.Generators
{
    using System;
    using CourseApp.Zoo.Interfaces;

    public class RandomPostGenerator : IRandomPostGenerator
    {
        private readonly Random _random;

        private readonly string[] _post = new[]
        {
            "Administrator",
            "Owner",
            "Cleaner",
            "Worker",
            "Manager",
            "Hard Worker",
            "Clown na ZP",
        };

        public RandomPostGenerator()
        {
            _random = new Random();
        }

        public string Generate()
        {
            return _post[_random.Next(0, _post.Length)];
        }
    }
}