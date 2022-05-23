namespace ClassTask
{
    using System;

    public class EvilTotalitarianCountry : Country
    {
        public EvilTotalitarianCountry(string name, int area, int population, string predominantNationality, string prevailingReligion, string officialLanguage, string currency, long gdp, string politicalSystem, bool isConquered, string chiefName)
            : base(name, area, population, predominantNationality, prevailingReligion, officialLanguage, currency, gdp, politicalSystem, isConquered)
        {
            ChiefName = chiefName;
        }

        public string ChiefName { get; set; }

        public override void CelebratingHoliday()
        {
            Console.WriteLine($"{Name} празднует государственный праздник! Вождь выступил с речью. Ура, товарищи!");
        }

        public override void StartWar(ICountry country)
        {
            Console.WriteLine($"Долой капиталистов! За Вождя! Вы сбрасываете бомбу на страну {country.Name}.");
            country.Population = 0;
            country.IsConquered = true;
        }

        public void GoToGulag(int numberOfVictims)
        {
            Console.WriteLine($"Вы отправили в ГУЛАГ {numberOfVictims} человек. Так держать, Вождь!");
            Population -= numberOfVictims;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Вождь:\t\t\t\t{ChiefName}");
            base.GetInfo();
        }
    }
}