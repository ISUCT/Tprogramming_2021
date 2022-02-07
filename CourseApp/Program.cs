namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            int applicants = 0;
            var battle = new Battle();
            applicants = battle.BattleStart(applicants);
        }
    }
}