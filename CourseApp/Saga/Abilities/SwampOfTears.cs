namespace CourseApp
{
    using CourseApp.Saga.Interface;

    public class SwampOfTears : IAbility
    {
        public SwampOfTears(int loss)
        {
            Multiplier = 1.4;
            Loss = (int)(Multiplier * loss);
            Name = "Swamp of tears";
            IsFire = false;
            IsFreese = false;
            IsPoison = true;
        }

        public int Loss { get; set; }

        public string Name { get; }

        public bool IsFreese { get; }

        public bool IsPoison { get; }

        public bool IsFire { get; }

        public double Multiplier { get; }

        public override string ToString()
        {
            return $"The enemy drowned in a poisonous quagmire";
        }
    }
}