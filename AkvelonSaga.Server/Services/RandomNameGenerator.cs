using AkvelonSaga.Server.Abstractions;
using AkvelonSaga.Server.Extensions;

namespace AkvelonSaga.Server.Services
{
    internal sealed class RandomNameGenerator : IRandomNameGenerator
    {
        private readonly string[] _firstNames = new[]
        {
            "Бандерлог",
            "Бамблби",
            "Беннихилл",
            "Барабас",
            "Бадминтон",
            "Базилик",
            "Бекмамбет",
            "Бургеркинг",
            "Будапешт",
            "Баттлфилд",
        };
        
        private readonly string[] _lastNames = new[]
        {
            "Кукумбер",
            "Казантип",
            "Кандибобер",
            "Трахтенберг",
            "Кабачок",
            "Камамбер",
            "Киберскотч",
            "Овервотч",
            "Драмнбейс",
            "Курткобейн",
            "Когтевран",
            "Репликит"
        };
        
        public string Generate()
        {
            var firstName = _firstNames.GetRandomValue();
            var lastName = _lastNames.GetRandomValue();

            return $"{firstName} {lastName}";
        }
    }
}
