namespace CourseApp.Class
{
    using System;
    using static System.Math;

    public static class CheckValues
    {
        public static void CheckValueForNullEmptyOrWhiteSpace(string value)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new Exception("Invalid value. Value can not be null, empty or whitespace.");
            }
        }

        public static void CheckValueForNullEmptyOrWhiteSpace(double value)
        {
            if (value <= 0)
            {
                throw new Exception("Invalid value. Value can not be below zero.");
            }
        }
    }
}