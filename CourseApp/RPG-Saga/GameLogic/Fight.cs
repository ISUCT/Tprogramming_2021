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
                if (player_1.Ability.IsUsed == true)
                {
                    player_1.Ability.Cast(player_1, player_2);
                }

                if (player_1.IsStunned != true)
                {
                    if (player_1.Ability.IsUsed != true && rnd.Next(100) > 70)
                    {
                        player_1.Ability.Cast(player_1, player_2);
                    }
                    else
                    {
                        player_1.ApplyDamage(player_2);
                    }
                }

                if (player_2.Health <= 0)
                {
                    Logger.Death(player_2.Name, player_2.RoleName, player_1.Name, player_1.RoleName);

                    player_1.Reset();
                    return player_1;
                }

                // 2ой игрок ходит
                if (player_2.Ability.IsUsed == true)
                {
                    player_2.Ability.Cast(player_2, player_1);
                }

                if (player_2.IsStunned != true)
                {
                    if (player_2.Ability.IsUsed != true && rnd.Next(100) > 70)
                    {
                        player_2.Ability.Cast(player_2, player_1);
                    }
                    else
                    {
                        player_2.ApplyDamage(player_1);
                    }
                }

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
