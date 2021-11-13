namespace CourseApp
{
    using System;

    public class Cat
    {
        private string name;
        private double tailLength;

        public Cat(int age, string name, double tailLength)
        {
            if (age < 0)
            {
                throw new ArgumentException();
            }
            else
            {
                this.Age = age;
            }

            if (name == string.Empty || name.Length == 0)
            {
                throw new System.ArgumentException();
            }
            else
            {
                this.name = name;
            }

            if (tailLength < 0)
            {
                throw new System.ArgumentException();
            }
            else
            {
                this.tailLength = tailLength;
            }
        }

        public Cat()
        {
            this.Age = 0;
            this.Name = "Not named :c";
            this.TailLength = 0;
        }

        public int Age { get; set; }

        public string Name { get => name; set => name = value; }

        public double TailLength { get => tailLength; set => tailLength = value; }

        public void PrintInformation()
        {
            Console.WriteLine("Name: " + this.name + "\nAge: " + this.Age + "\nTail Length: " + this.tailLength);
            Console.Write(
                " |\\---/|" +
"   | , _, |" +
"    \\_`_ / -..----." +
" ___ / `   ' ,\"\"+ \\  " +
"(__...'   __\\    |`.___.';" +
"            (_, ...'(_,.`__)/'.....+");
        }

        public void Sound()
        {
            Console.WriteLine(this.name + "said Meow");
        }

        public int GetHumanAge()
        {
            return this.Age * 5;
        }
    }
}
