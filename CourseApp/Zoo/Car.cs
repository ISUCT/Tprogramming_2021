namespace CourseApp.Zoo
{
    public class Car : Staff, IDraw
    {
        private string model;
        private Driver driver = null;

        public Car(int id, string model)
            : base(id)
        {
            this.model = model;
        }

        public string Draw()
        {
            return $"Model: {model}||Driver: {(driver == null ? "none" : driver.Draw())}";
        }

        public void SetDr(Driver driver)
        {
            this.driver = driver;
        }
    }
}
