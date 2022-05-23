namespace ClassTask
{
    public interface ICountry
    {
        string Name { get; set; }

        int Area { get; set; }

        int Population { get; set; }

        string PredominantNationalyty { get; set; }

        string PrevailingReligion { get; set; }

        string OfficialLanguage { get; set; }

        string Currency { get; set; }

        long GDP { get; set; }

        string PoliticalSystem { get; set; }

        bool IsConquered { get; set; }

        void CelebratingHoliday();

        void StartWar(ICountry country);

        int GetGDP_perCapita(long gdp, int population);

        void ChangePoliticalSystem();

        void GetInfo();
    }
}