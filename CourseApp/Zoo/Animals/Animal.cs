namespace CourseApp.Zoo.Animals
{
    using CourseApp.Zoo.Interfaces;

    public abstract class Animal : IAnimal, IDrawable
    {
        private int _age;

        public Animal(string name, int age, string sex)
        {
            Name = name;
            Age = age;
            Sex = sex;
        }

        public string Name { get; set; }

        public int Age
        {
            get => _age;

            set => _age = value is >= 0 and < 20 ? value : 0;
        }

        public string Sex { get; set; }

        public abstract string Draw();
    }
}
