﻿namespace CourseApp
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var mike = new CalculatingAPersonsAge();
            Console.WriteLine(mike.CalculatingAge(new DateTime(2002, 12, 20), new DateTime(2022, 1, 3)));
            var calc = new Calculator();
            Console.WriteLine($"5 * 10 = {calc.Multi(5, 10)}");
            var tasks = new Tasks();
            Console.WriteLine($"x = 0.11  result: {tasks.Function(0.11)}");
            var ak47 = new AssaultRifle("AK 47", 2005, "jskonst");
            Console.WriteLine($"Model: {ak47.Model}  Owner: {ak47.Owner}  Year: {ak47.Year}");
        }
    }
}
