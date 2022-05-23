namespace ClassTask
{
    using System;

    public class KindDemocraticCountry : Country
    {
        public KindDemocraticCountry(string name, int area, int population, string predominantNationality, string prevailingReligion, string officialLanguage, string currency, long gdp, string politicalSystem, bool isConquered, string parliamentType, int numberOfParliamentarians)
            : base(name, area, population, predominantNationality, prevailingReligion, officialLanguage, currency, gdp, politicalSystem, isConquered)
        {
            ParliamentType = parliamentType;
            NumberOfParliamentarians = numberOfParliamentarians;
        }

        public string ParliamentType { get; set; }

        public int NumberOfParliamentarians { get; set; }

        public override void CelebratingHoliday()
        {
            Console.WriteLine($"{Name} празднует государственный праздник! Жители ликуют. За Демократию!");
        }

        public override void StartWar(ICountry country)
        {
            Console.WriteLine($"Пора положить конец тирании! Вы начинаете войну против страны {country.Name}.");
            country.IsConquered = true;
        }

        public void MakeItGreatAgain()
        {
            Console.WriteLine($"Вы сделали страну {Name} снова великой. Что изменилось?..");
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Тип парламента:\t\t\t{ParliamentType}\n" +
                $"Число парламентариев:\t\t{NumberOfParliamentarians}");
        }
    }
}
