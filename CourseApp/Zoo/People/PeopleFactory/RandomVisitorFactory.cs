namespace CourseApp.Zoo.People.PeopleFactory
{
    using CourseApp.Zoo.Generators;
    using CourseApp.Zoo.People.Generators;

    public class RandomVisitorFactory : IRandomPeopleFactory
    {
        private readonly RandomPeopleNameGenerator _peopleNameGenerator;

        private readonly RandomPeopleAgeGenerator _peopleAgeGenerator;

        private readonly RandomSexGenerator _sexGenerator;

        public RandomVisitorFactory()
        {
            _peopleAgeGenerator = new RandomPeopleAgeGenerator();
            _peopleNameGenerator = new RandomPeopleNameGenerator();
            _sexGenerator = new RandomSexGenerator();
        }

        public Person Create()
        {
            var name = _peopleNameGenerator.Generate();
            var age = _peopleAgeGenerator.Generate();
            var sex = _sexGenerator.Generate();
            return new Visitor(name, age, sex);
        }
    }
}