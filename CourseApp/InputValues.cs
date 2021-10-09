namespace CourseApp
{
    using System;

    public class InputValues
    {
        public string InputString()
        {
            var item = string.Empty;
            var isCorrect = false;
            var check = new CheckValueForCorrect();
            while (!isCorrect)
            {
                item = Console.ReadLine();
                isCorrect = check.IsValidString(item);
            }

            return item;
        }

        public int InputInt(int maxValue)
        {
            return InputInt(0, maxValue);
        }

        public int InputInt(int minValue, int maxValue)
        {
            int intInput = 0;
            var isCorrect = false;
            var check = new CheckValueForCorrect();
            while (!isCorrect)
            {
                var item = Console.ReadLine();
                if (int.TryParse(item, out intInput))
                {
                    isCorrect = check.IsValidInt(intInput, minValue, maxValue);
                }
                else
                {
                    Console.WriteLine($"Value ({item}) is not a integer. Please enter correct value!");
                }
            }

            return intInput;
        }

        public double InputDouble(double maxValue)
        {
            return InputDouble(0, maxValue);
        }

        public double InputDouble(double minValue, double maxValue)
        {
            double doubleInput = 0;
            var isCorrect = false;
            var check = new CheckValueForCorrect();
            while (!isCorrect)
            {
                var item = Console.ReadLine();
                if (double.TryParse(item, out doubleInput))
                {
                    isCorrect = check.IsValidDouble(doubleInput, minValue, maxValue);
                }
                else
                {
                    Console.WriteLine($"Value ({item}) is not a double. Please enter correct value!");
                }
            }

            return doubleInput;
        }
    }
}