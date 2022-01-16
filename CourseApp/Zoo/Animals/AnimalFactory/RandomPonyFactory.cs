namespace CourseApp.Zoo.Animals.AnimalFactory
{
    using CourseApp.Zoo.Animals.Generators;
    using CourseApp.Zoo.Generators;

    public class RandomPonyFactory : IRandomAnimalFactory
    {
        private readonly RandomAnimalAgeGenerator _animalAgeGenerator;

        private readonly RandomAnimalNameGenerator _animalNameGenerator;

        private readonly RandomSexGenerator _sexGenerator;

        public RandomPonyFactory()
        {
            _animalAgeGenerator = new RandomAnimalAgeGenerator();
            _animalNameGenerator = new RandomAnimalNameGenerator();
            _sexGenerator = new RandomSexGenerator();
        }

        public Animal Create()
        {
            var name = _animalNameGenerator.Generate();
            var age = _animalAgeGenerator.Generate();
            var sex = _sexGenerator.Generate();
            return new Pony(name, age, sex);
        }
    }
}