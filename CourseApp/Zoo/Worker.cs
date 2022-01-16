namespace CourseApp.Zoo
{
    public class Worker : Employee, IDraw
    {
        private Shovel shovel = null;

        public Worker(string name, string secodname, int age, int exp)
            : base(name, secodname, age, exp)
        {
        }

        public new string Draw()
        {
            return $"{base.Draw()}||Staff: {(shovel == null ? "none" : $"Shovel: {shovel.GetSh()}")}";
        }

        public void SetShovel(Shovel sh)
        {
            shovel = sh;
        }
    }
}
