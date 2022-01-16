namespace CourseApp.Zoo
{
    public class Init
    {
        public static void Main_Init()
        {
            Driver driver = new Driver("Sam", "Adams", 30, 5);
            Car car = new Car(412, "Opel");
            driver.SetCar(car);
            InterFace interFace = new InterFace();
            interFace.Draw(car);

            Worker worker = new Worker("Vladimir", "Kojuhar", 30, 5);
            Shovel shovel = new Shovel(123, 6);
            worker.SetShovel(shovel);
            interFace.Draw(worker);
        }
    }
}
