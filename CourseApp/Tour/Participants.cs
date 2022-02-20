namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public class Participants
    {
        private readonly Random random = new Random();
        private List<string> arrayOfName = new List<string>()
        {
        "Сергор", "Тана", "Миваль", "Натали", "Валек", "Мэнни", "Шилли", "Фарила", "Мара", "Зашеир", "Хасеир",
        "Асеир", "Гузлик", "Линкольн", "Зашеир", "Ригард", "Мехмед", "Незуко", "Танджиро", "Субару", "Рэм",
        "Аот", "Урхур", "Нефис", "Азар-Де", "Мара", "Ромеро", "Хуектория", "Додик", "Эссвелэ", "Дима",
        "Румян", "Кто-то",
        };

        private List<Player> warriors = new List<Player>();

        public List<Player> AddAtList(int participants)
        {
            while (warriors.Count < participants)
            {
                switch (random.Next(0, 3))
                {
                    case 0:
                        warriors.Add(new Archer(arrayOfName[random.Next(0, 20)], random.Next(100, 130), random.Next(10, 20)));
                        break;
                    case 1:
                        warriors.Add(new Knight(arrayOfName[random.Next(0, 20)], random.Next(100, 130), random.Next(10, 20)));
                        break;
                    case 2:
                        warriors.Add(new Wizard(arrayOfName[random.Next(0, 20)], random.Next(100, 130), random.Next(10, 20)));
                        break;
                }
            }

            return warriors;
        }
    }
} 