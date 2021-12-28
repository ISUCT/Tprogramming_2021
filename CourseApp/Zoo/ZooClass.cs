namespace CourseApp.Zoo
{
    using System;
    using System.Collections.Generic;
    using CourseApp.Zoo.Animals;
    using CourseApp.Zoo.Objects;
    using CourseApp.Zoo.People;

    public class ZooClass : IDrawable
    {
        public ZooClass(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public List<IDrawable> Animals()
        {
            var listAnimals = new List<IDrawable>();
            listAnimals.Add(new Dog("Sharik", 2, "Male"));
            listAnimals.Add(new Cat("Barsik", 4, "Female"));
            listAnimals.Add(new Pony("RaindowDash", 7, "Female"));
            return listAnimals;
        }

        public List<IDrawable> People()
        {
            var listPeople = new List<IDrawable>();
            listPeople.Add(new Employee("Vladimir Kozhukhar", 18, "Male", "Administrator"));
            listPeople.Add(new Employee("Mark Rumyantsev", 19, "Male", "Hard Worker"));
            listPeople.Add(new Visitor("Aleksei Polekhin", 19, "Male"));
            listPeople.Add(new Visitor("Varvara Troshina", 19, "Female"));
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
            return "That is all our Zoo!";
        }
    }
}