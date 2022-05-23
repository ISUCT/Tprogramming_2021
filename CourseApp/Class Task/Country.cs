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

        public int GetGDP_perCapita(long gdp, int population)
        {
            return (int)(gdp / population);
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
}