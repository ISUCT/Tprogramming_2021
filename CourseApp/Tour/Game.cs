namespace CourseApp
{
    using System;

    public class Game
    {
        public int StartTheTournament(int tourname)
        {
            Logger.LoggerOutput("Введите количество участников турнира: ");
            tourname = Convert.ToInt32(Console.ReadLine());
            while ((tourname % 2 != 0) && (tourname > 0))
            {
                Logger.LoggerOutput("Введите корректное количество участников турнира: ");
                tourname = Convert.ToInt32(Console.ReadLine());
            }

            return tourname;
        }
    }
}