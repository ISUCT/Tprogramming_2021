namespace CourseApp
{
    using System;

    public class Battle
    {
        public int BattleStart(int applicants)
        {
            Console.WriteLine("Введите количество слотов для участников: ");
            applicants = Convert.ToInt32(Console.ReadLine());
            while ((applicants % 2 != 0) || (applicants < 0))
            {
                Console.WriteLine("Введите количество слотов для участников(кратно 2) ");
                applicants = Convert.ToInt32(Console.ReadLine());
            }

            return applicants;
        }
    }
}