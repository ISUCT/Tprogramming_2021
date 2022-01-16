namespace CourseApp.Zoo.People.PeopleFactory
{
    using CourseApp.Zoo.Generators;
    using CourseApp.Zoo.People.Generators;

    public class RandomEmployeeFactory : IRandomPeopleFactory
    {
        private readonly RandomSexGenerator _sexGenerator;

        private readonly RandomPeopleNameGenerator _peopleNameGenerator;

        private readonly RandomPeopleAgeGenerator _peopleAgeGenerator;

        private readonly RandomPostGenerator _postGenerator;

        public RandomEmployeeFactory()
        {
            _peopleNameGenerator = new RandomPeopleNameGenerator();
            _postGenerator = new RandomPostGenerator();
            _sexGenerator = new RandomSexGenerator();
            _peopleAgeGenerator = new RandomPeopleAgeGenerator();
        }

        public Person Create()
        {
            var name = _peopleNameGenerator.Generate();
            var age = _peopleAgeGenerator.Generate();
            var post = _postGenerator.Generate();
            var sex = _sexGenerator.Generate();
            return new Employee(name, age, sex, post);
        }
    }
}