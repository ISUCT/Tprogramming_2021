namespace CourseApp.RPG_Saga.GameLogic
{
    using System;
    using System.Collections.Generic;
    using CourseApp.RPG_Saga.Logger_;

    public static class Round
    {
        public static List<Player> StartRound(List<Player> players)
        {
            List<Player> winnersList = new List<Player>();
            Random rnd = new Random();
            int numOfFight = 0;

            for (var i = 0; i < players.Count; i += 2)
            {
                numOfFight++;
                Logger.FightAnnouncement(numOfFight);

                winnersList.Add(Fight.StartFight(players[i], players[i + 1]));
            }

            // Перемешивание элементов массива:
            if (winnersList.Count > 1)
            {
                for (int i = 0; i < winnersList.Count; i++)
                {
                    int j = rnd.Next(i + 1);

                    Player tmp = winnersList[j];
                    winnersList[j] = winnersList[i];
                    winnersList[i] = tmp;
                }
            }

            return winnersList;
        }
    }
}
