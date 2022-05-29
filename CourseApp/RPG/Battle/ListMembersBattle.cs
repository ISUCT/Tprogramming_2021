namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public class ListMembersBattle
    {
        private readonly Random random = new Random();

        private readonly string[] arrName = new string[17]
        {
            "Капитан Ник Рейес",
            "Сален Котч",
            "Маркус Холлоуэй",
            "Ренч",
            "Ноктис Люцис Цэлум",
            "Таккар",
            "Шерлок Холмс",
            "Джейсон Вурхез",
            "Джек Джойс",
            "Ли Эверетт",
            "Луис Фернандо Лопес",
            "Конан",
            "Джейк Мюллер",
            "Экстон ",
            "Джон Сноу",
            "Дюк Нюкем",
            "Брюс Уэйн",
        };

        private List<Player> units = new List<Player>();

        public List<Player> AddAtList(int tournamentParticipants)
        {
            while (units.Count < tournamentParticipants)
            {
                switch (random.Next(0, 3))
                {
                    case 0:
                        units.Add(new Archer(arrName[random.Next(0, 17)], random.Next(100, 130), random.Next(10, 20)));
                        break;
                    case 1:
                        units.Add(new Knight(arrName[random.Next(0, 17)], random.Next(100, 130), random.Next(10, 20)));
                        break;
                    case 2:
                        units.Add(new Mage(arrName[random.Next(0, 17)], random.Next(100, 130), random.Next(10, 20)));
                        break;
                }
            }

            return units;
        }
    }
}
