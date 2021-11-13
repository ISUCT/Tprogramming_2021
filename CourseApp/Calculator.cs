namespace CourseApp
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public float Add(float a, float b)
        {
            return a + b;
        }

        public byte Add(byte a, byte b)
        {
            if ((int)a + (int)b < 255)
            {
                return (byte)((int)a + (int)b);
            }

            throw new System.OverflowException("You are trying to add two 8-bit numbers, which sum is more than 8-bit");
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }

        public double Sub(double a, double b)
        {
            return a - b;
        }

        public float Sub(float a, float b)
        {
            return a - b;
        }

        public byte Sub(byte a, byte b)
        {
            if ((int)a - (int)b > 0)
            {
                return (byte)((int)a + (int)b);
            }

            throw new System.OverflowException("You are trying to subtract two unsigned, which result of wubtracting is less than zero");
        }
    }
}
