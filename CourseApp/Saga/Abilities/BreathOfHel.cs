namespace CourseApp
{
    using CourseApp.Saga.Interface;

    public class BreathOfHel : IAbility
    {
        public BreathOfHel(int loss)
        {
            Multiplier = 1.6;
            Loss = (int)(Multiplier * loss);
            Name = "Breath of Hel";
            IsFire = false;
            IsFreese = true;
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
            return $"The soul of the enemy is frozen forever";
        }
    }
}