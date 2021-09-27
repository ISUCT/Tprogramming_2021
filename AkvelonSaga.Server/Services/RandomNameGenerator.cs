using System;
using AkvelonSaga.Server.Abstractions;

namespace AkvelonSaga.Server.Services
{
    public sealed class RandomNameGenerator : IRandomNameGenerator
    {
        private static readonly Random Random = new();
        
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
        };
        
        public string Generate()
        {
            var firstName = _firstNames[Random.Next(0, _firstNames.Length)];
            var lastName = _lastNames[Random.Next(0, _lastNames.Length)];

            return $"{firstName} {lastName}";
        }
    }
}
