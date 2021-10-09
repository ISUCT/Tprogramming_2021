namespace CourseApp
{
    using System;

    public class CheckValueForCorrect
    {
        public bool IsValidString(string item)
        {
            bool isValidValue = false;
            if (string.IsNullOrEmpty(item) || string.IsNullOrWhiteSpace(item))
            {
                isValidValue = false;
                Console.WriteLine("Value is null or empty or contains invalid characters or whitespace. Please enter correct value!");
            }
            else
            {
                isValidValue = true;
            }

            return isValidValue;
        }

        public bool IsValidInt(int item, int minValue, int maxValue)
        {
            bool isValidValue = false;
            if (item < minValue || item > maxValue)
            {
                Console.WriteLine($"Value ({item}) is out of range. Please enter correct value!");
                isValidValue = false;
            }
            else
            {
                isValidValue = true;
            }

            return isValidValue;
        }

        public bool IsValidDouble(double item, double minValue, double maxValue)
        {
            bool isValidValue = false;
            if (item < minValue || item > maxValue)
            {
                Console.WriteLine($"Value ({item}) is out of range. Please enter correct value!");
                isValidValue = false;
            }
            else
            {
                isValidValue = true;
            }

            return isValidValue;
        }
    }
}