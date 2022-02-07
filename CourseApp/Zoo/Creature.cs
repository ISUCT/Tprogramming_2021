namespace CourseApp.Zoo
{
    public class Creature : IDraw
    {
        private string kind;
        private string name;
        private int age;
        private Cage cage;

        public Creature(string name, int age, string kind)
        {
            if (age > 0 && age < 100)
            {
                this.age = age;
            }
            else
            {
                this.age = -1;
            }

            this.name = name;
            this.kind = kind;
        }

        public string Draw()
        {
            return $"Kind: {kind}||Name: {name}||Age: {(age == -1 ? "missing" : $"{age}years")} \n";
        }

        public void SetCage(Cage cage)
        {
            this.cage = cage;
            cage.SetOc(this);
        }
    }
}
