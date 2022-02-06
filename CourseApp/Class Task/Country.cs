namespace ClassTask
{
    using System;

    public abstract class Country : ICountry
    {
        public Country(string name, int area, int population, string predominantNationality, string prevailingReligion, string officialLanguage, string currency, long gdp, string politicalSystem, bool isConquered)
        {
            Name = name;
            Area = area;
            Population = population;
            PredominantNationalyty = predominantNationality;
            PrevailingReligion = prevailingReligion;
            OfficialLanguage = officialLanguage;
            Currency = currency;
            GDP = gdp;
            PoliticalSystem = politicalSystem;
            IsConquered = isConquered;
        }

        public string Name { get; set; }

        public int Area { get; set; }

        public int Population { get; set; }

        public string PredominantNationalyty { get; set; }

        public string PrevailingReligion { get; set; }

        public string OfficialLanguage { get; set; }

        public string Currency { get; set; }

        public long GDP { get; set; }

        public string PoliticalSystem { get; set; }

        public bool IsConquered { get; set; }

        public abstract void CelebratingHoliday();

        public abstract void StartWar(ICountry country);

        public void ChangePoliticalSystem()
        {
            PoliticalSystem = (PoliticalSystem == "Тоталитаризм") ? "Тоталитаризм" : "Демократия";
        }

        public int GetGDP_perCapita(long GDP, int population)
        {
            return (int)(GDP / population);
        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"Название:\t\t\t{Name}\n" +
                $"Площадь:\t\t\t{Area}\n" +
                $"Население:\t\t\t{Population}\n" +
                $"Преобладающая национальность:\t{PredominantNationalyty}\n" +
                $"Преобладающая религия:\t\t{PrevailingReligion}\n" +
                $"Государственный язык:\t\t{OfficialLanguage}\n" +
                $"Валюта:\t\t\t\t{Currency}\n" +
                $"ВВП:\t\t\t\t{GDP}\n" +
                $"Политический режим:\t\t{PoliticalSystem}\n" +
                $"Завоевана:\t\t\t{(IsConquered == false ? "Нет" : "Да")}");
        }
    }

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