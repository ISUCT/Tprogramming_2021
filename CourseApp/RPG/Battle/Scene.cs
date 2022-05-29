namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public class Scene
    {
        private readonly Random random = new Random();
        private Logger logger = new Logger();
        private List<Player> units = new List<Player>();
        private List<Player> winners = new List<Player>();
        private ListMembersBattle list = new ListMembersBattle();

        private int round = 1;

        private Fighting fighting = new Fighting();

        public void Tournament(int tournamentParticipants)
        {
            units = list.AddAtList(tournamentParticipants);

            Logger.LoggerOutput("Юниты перед нами!");
            foreach (Player item in units)
            {
                Logger.LoggerOutput($"Юнит {item.Name}, {item.ClassHero}");
            }

            Logger.LoggerOutput("Турнир «Doka 3» начинается!");
            Logger.LoggerOutput($"Номер поединика {round++}-й");
            while (units.Count + winners.Count > 1)
            {
                if (units.Count >= 2)
                {
                    int randomUnitFirst = random.Next(0, units.Count);
                    int randomUnitSecond = random.Next(0, units.Count);
                    while (randomUnitFirst == randomUnitSecond)
                    {
                        randomUnitSecond = random.Next(0, units.Count);
                    }

                    Player unit = units[randomUnitFirst];
                    Player unitRival = units[randomUnitSecond];
                    Logger.LoggerOutput($"Так, начинается бой! {unit.ClassHero}  {unit.Name} vs {unitRival.ClassHero}  {unitRival.Name} \n");
                    fighting.BattleCup(unit, unitRival);
                    Console.WriteLine("\n");
                    if (unit.Health <= 0)
                    {
                        Logger.LoggerOutput($"{unit.ClassHero} {unit.Name} потерпел(а) поражение и отправляется наблюдать за продолжением турнира :(");
                        unitRival.ResetHealth();
                        units.Remove(unit);
                        units.Remove(unitRival);
                        winners.Add(unitRival);
                    }
                    else
                    {
                        Logger.LoggerOutput($"{unitRival.ClassHero} {unitRival.Name} потерпел(а) поражение и отправляется наблюдать за продолжением турнира :(");
                        unit.ResetHealth();
                        units.Remove(unit);
                        units.Remove(unitRival);
                        winners.Add(unit);
                    }
                }

                if ((winners.Count >= 2) && (units.Count == 0))
                {
                    int randomUnitsFirst = random.Next(0, winners.Count);
                    int randomUnitsSecond = random.Next(0, winners.Count);
                    while (randomUnitsFirst == randomUnitsSecond)
                    {
                        randomUnitsSecond = random.Next(0, winners.Count);
                    }

                    Logger.LoggerOutput($"Номер поединика {round++}-й");
                    Player units = winners[randomUnitsFirst];
                    Player unitRival = winners[randomUnitsSecond];
                    Logger.LoggerOutput($"Так, начинается бой! {units.ClassHero}  {units.Name} vs {unitRival.ClassHero}  {unitRival.Name} \n");
                    fighting.BattleCup(units, unitRival);
                    if (units.Health <= 0)
                    {
                        Logger.LoggerOutput($"{units.ClassHero} {units.Name} потерпел(а) поражение и отправляется наблюдать за продолжением турнира :(");
                        unitRival.ResetHealth();
                        winners.Remove(units);
                    }
                    else
                    {
                        Logger.LoggerOutput($"{unitRival.ClassHero} {unitRival.Name} потерпел(а) поражение и отправляется наблюдать за продолжением турнира :(");
                        units.ResetHealth();
                        winners.Remove(unitRival);
                    }
                }
            }

            Logger.LoggerOutput($"Выиграл турнир - {winners[0].ClassHero} {winners[0].Name}!");
            Logger.LoggerOutput("Турнир окончен, всем спасибо!");
        }
    }
}