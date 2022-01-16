namespace CourseApp.Zoo
{
    public class Driver : Employee
    {
        private Car car = null;

        public Driver(string name, string secodname, int age, int exp)
            : base(name, secodname, age, exp)
        {
        }

        public void SetCar(Car car)
        {
            this.car = car;
            car.SetDr(this);
        }

        public new string Draw()
        {
            return $"{base.Draw()} \n";
        }
    }
}
