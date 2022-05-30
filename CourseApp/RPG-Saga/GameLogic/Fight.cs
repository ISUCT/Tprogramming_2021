namespace CourseApp.RPG_Saga.GameLogic
{
    using System;
    using CourseApp.RPG_Saga.Logger_;

    public static class Fight
    {
        public static Player StartFight(Player player_1, Player player_2)
        {
            Random rnd = new Random();
            while (true)
            {
                // 1ый игрок ходит
                player_1.MakeMove(player_2);

                BattleManager.CheckPlayer(player_2);

                if (player_2.Health <= 0)
                {
                    Logger.Death(player_2.Name, player_2.RoleName, player_1.Name, player_1.RoleName);

                    player_1.Reset();
                    return player_1;
                }

                // 2ой игрок ходит
                player_2.MakeMove(player_1);

                BattleManager.CheckPlayer(player_1);

                if (player_1.Health <= 0)
                {
                    Logger.Death(player_1.Name, player_1.RoleName, player_2.Name, player_2.RoleName);

                    player_2.Reset();
                    return player_2;
                }
            }
        }
    }
}
