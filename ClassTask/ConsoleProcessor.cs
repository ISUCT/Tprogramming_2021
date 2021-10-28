using System;

namespace ClassTask
{
    static class ConsoleProcessor
    {
        const string menu = "Что вы хотите сделать?\n" +
@"1. Показать текущую информацию о стране
2. Отметить национальный праздник
3. Начать войну против другого государства
4. Узнать текущий ВВП на душу населения";


        public static void Start(KindDemocraticCountry country_1, EvilTotalitarianCountry country_2)
        {
            Console.Write($@"Добро пожаловать!

Пожалуйста, выберете страну:
1. {country_1.Name} ({country_1.PoliticalSystem})
2. {country_2.Name} ({country_2.PoliticalSystem})

Введите номер: ");
                        
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.Clear();
                    DemocraticMenu(country_1, country_2);
                    break;
                case 2:
                    Console.Clear();
                    TotalitarianMenu(country_2, country_1);
                    break;
            }               
        }

        public static void CommonMenuRealization(string i, ICountry country, ICountry enemyCountry)
        {
            switch(i)
            {
                case "1":
                    country.GetInfo();
                    break;
                case "2":
                    country.CelebratingHoliday();
                    break;
                case "3":
                    country.StartWar(enemyCountry);
                    break;
            }
        }

        public static void DemocraticMenu (KindDemocraticCountry country, ICountry enemyCountry)
        {
            string i;
            do
            {
                Console.WriteLine("Здравствуйте, господин Президент!\n");
                Console.WriteLine(menu);
                Console.Write(@"5. Сделать страну снова великой

Для выхода нажмите Enter
Введите номер: ");
                i = Console.ReadLine();
                switch (i)
                {
                    case "1":
                    case "2":
                    case "3":
                        Console.Clear();
                        CommonMenuRealization(i, country, enemyCountry);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine($"{country.GetGDP_perCapita(country.GDP, country.Population)}$ на человека");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "5":
                        Console.Clear();
                        country.MakeItGreatAgain();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
            while (i != "");      
        }

        public static void TotalitarianMenu(EvilTotalitarianCountry country, ICountry enemyCountry)
        {
            string i;
            do
            {
                Console.WriteLine($"Приветствую, Вождь {country.ChiefName}!\n");
                Console.WriteLine(menu);
                Console.Write(@"5. Отправить врагов революции в гулаг

Для выхода нажмите Enter
Введите номер: ");
                i = Console.ReadLine();
                switch (i)
                {
                    case "1":
                    case "2":
                    case "3":
                        Console.Clear();
                        CommonMenuRealization(i, country, enemyCountry);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "4":
                        Console.Clear();
                        country.GetGDP_perCapita(country.GDP, country.Population);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "5":
                        Console.Clear();
                        Console.Write("Сколько человек вы хотите отправить: ");
                        country.GoToGulag(Convert.ToInt32(Console.ReadLine()));
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }               
            }
            while (i != "");
        }
    }
}