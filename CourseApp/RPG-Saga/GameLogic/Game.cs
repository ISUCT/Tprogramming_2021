namespace CourseApp.RPG_Saga.GameLogic
{
    using System;
    using System.Collections.Generic;
    using CourseApp.RPG_Saga.Logger_;

    public static class Game
    {
        public static void StartGame(int numOfPlayers)
        {
            Random rnd = new Random();
            List<Player> players = new List<Player>();

            for (int i = 0; i < numOfPlayers; i++)
            {
                players.Add(Generator.Generate());
            }

            int numOfRounds = (int)Math.Log2(numOfPlayers);

            for (int i = 1; i <= numOfRounds; i++)
            {
                Logger.RoundAnnouncement(i);

                // List<Player> winners = new List<Player>();
                players = Round.StartRound(players);
            }
        }
    }
}