namespace CourseApp.Zoo.Animals
{
    public abstract class Animal : IAnimal
    {
        private int age;

        public Animal(string name, int age, string sex)
        {
            Name = name;
            Age = age;
            Sex = sex;
        }

        public string Name { get; set; }

        public int Age
        {
            get => age;

            set => age = value is >= 0 and < 100 ? value : 0;
        }

        public string Sex { get; set; }
    }
}
