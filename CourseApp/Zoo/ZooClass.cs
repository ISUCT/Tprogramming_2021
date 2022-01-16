namespace CourseApp.Zoo
{
    using System.Collections.Generic;
    using CourseApp.Zoo.Animals.AnimalFactory;
    using CourseApp.Zoo.Interfaces;
    using CourseApp.Zoo.Objects;
    using CourseApp.Zoo.People;
    using CourseApp.Zoo.People.PeopleFactory;

    public class ZooClass : IDrawable, IZoo
    {
        private readonly RandomDogFactory _dogFactory;

        private readonly RandomCatFactory _catFactory;

        private readonly RandomPonyFactory _ponyFactory;

        private readonly RandomEmployeeFactory _employeeFactory;

        private readonly RandomVisitorFactory _visitorFactory;

        public ZooClass(string name)
        {
            Name = name;
            _dogFactory = new RandomDogFactory();
            _ponyFactory = new RandomPonyFactory();
            _catFactory = new RandomCatFactory();
            _employeeFactory = new RandomEmployeeFactory();
            _visitorFactory = new RandomVisitorFactory();
        }

        public string Name { get; set; }

        public List<IDrawable> Animals()
        {
            var listAnimals = new List<IDrawable>();
            listAnimals.Add(_dogFactory.Create());
            listAnimals.Add(_catFactory.Create());
            listAnimals.Add(_ponyFactory.Create());
            return listAnimals;
        }

        public List<IDrawable> People()
        {
            var listPeople = new List<IDrawable>();
            listPeople.Add(_employeeFactory.Create());
            listPeople.Add(_employeeFactory.Create());
            listPeople.Add(_employeeFactory.Create());
            listPeople.Add(_visitorFactory.Create());
            listPeople.Add(_visitorFactory.Create());
            listPeople.Add(_visitorFactory.Create());
            listPeople.Add(_visitorFactory.Create());
            return listPeople;
        }

        public List<IDrawable> Objects()
        {
            var listObjects = new List<IDrawable>();
            listObjects.Add(new Buildings("Administration", "For Administrator"));
            listObjects.Add(new Buildings("Paddock", "For Animals"));
            listObjects.Add(new InteriorStaff("Road", "Between Administration and Paddock"));
            listObjects.Add(new InteriorStaff("Lamp", "For good lightning"));
            return listObjects;
        }

        public string Draw()
        {
            var newInterface = new UserInterface();
            newInterface.Draw(People());
            newInterface.Draw(Animals());
            newInterface.Draw(Objects());
            return $"That is all our {Name} Zoo!";
        }
    }
}