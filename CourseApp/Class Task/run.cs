namespace ClassTask
{
    public class Run
    {
        public static void RunTask()
        {
            KindDemocraticCountry country_1 = new KindDemocraticCountry("Акирема", 9826675, 331449281, "Акиремцы", "Христианство", "Английский", "Доллар", 22675271000000, "Демократия", false, "Конгресс", 535);

            EvilTotalitarianCountry country_2 = new EvilTotalitarianCountry("РССС", 9826675, 331449281, "Товарищи", "Атеизм", "Русский", "Рубль", 22675271000000, "Тоталитаризм", false, "Сталин");

            ConsoleProcessor.Start(country_1, country_2);
        }
    }
}
