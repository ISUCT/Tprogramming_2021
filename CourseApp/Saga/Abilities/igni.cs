namespace CourseApp
{
    using CourseApp.Saga.Interface;

    public class Igni : IAbility
    {
        public Igni(int loss)
        {
            Multiplier = 1.7;
            Loss = (int)(Multiplier * loss);
            Name = "Igni sign";
            IsFire = true;
            IsFreese = false;
            IsPoison = false;
        }

        public int Loss { get; set; }

        public string Name { get; }

        public bool IsFreese { get; }

        public bool IsPoison { get; }

        public bool IsFire { get; }

        public double Multiplier { get; }

        public override string ToString()
        {
            return $"The enemy burned down";
        }
    }
}