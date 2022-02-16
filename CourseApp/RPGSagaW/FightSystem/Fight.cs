namespace RPGSagaW.FightSystem;
using RPGSagaW;
using RPGSagaW.Players;

public static class Fight
{
    public static void AtackPlayer(Player atacker, Player getAtack)
    {
        getAtack.Health -= atacker.Damage;
        Logger.PlayerAttack(atacker, getAtack);
    }

    public static bool CheckPlayerDeath(Player p1, Player p2)
    {
        if (p1.Health <= 0 || p2.Health <= 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public static Player CheckWinner(Player p1, Player p2)
    {
        if (p1.Health <= 0)
        {
            Logger.PlayerWin(p2);
            return p2;
        }
        else
        {
            Logger.PlayerWin(p1);
            return p1;
        }
    }

    public static List<object> SavePlayerStats(Player p1, Player p2)
    {
        List<object> stats = new List<object>();
        stats.Add(p1.Health);
        stats.Add(p1.Damage);
        stats.Add(p1.UsedAbility);
        stats.Add(p1.Stun);
        stats.Add(p2.Health);
        stats.Add(p2.Damage);
        stats.Add(p2.UsedAbility);
        stats.Add(p2.Stun);
        return stats;
    }

    public static void RestorePlayerStats(List<object> stats, Player p1, Player p2)
    {
        p1.Health = (int)stats[0];
        p1.Damage = (int)stats[1];
        p1.UsedAbility = (bool)stats[2];
        p1.Stun = (bool)stats[3];
        p2.Health = (int)stats[4];
        p2.Damage = (int)stats[5];
        p2.UsedAbility = (bool)stats[6];
        p2.Stun = (bool)stats[7];
    }

    public static void ReturnPlayerToList(Player p)
    {
        CreatePlayers.AddPlayerToList(p);
    }

    public static List<Player> SelectPlayersForFight(List<Player> players)
    {
        List<Player> playersForFight = new List<Player>();

        int p1 = Random.Shared.Next(0, players.Count);
        playersForFight.Add(players[p1]);
        players.Remove(players[p1]);

        int p2 = Random.Shared.Next(0, players.Count);
        playersForFight.Add(players[p2]);
        players.Remove(players[p2]);

        return playersForFight;
    }

    public static void StartFight(List<Player> players)
    {
        List<object> StatsBeforeFight = SavePlayerStats(players[0], players[1]);

        int turn = Turn.RandomFirstTurn();

        while (CheckPlayerDeath(players[0], players[1]))
        {
            if (turn == 0)
            {
                if (FightAbility.CheckAbilityUse(players[0], players[0].UsedAbility) && FightAbility.ChanceToUseAbility())
                {
                    FightAbility.UseAbility(players[0]);
                }
                else
                {
                    AtackPlayer(players[0], players[1]);
                }
                Turn.ChangeTurn(ref turn);
            }
            else
            {
                if (FightAbility.CheckAbilityUse(players[1], players[1].UsedAbility) && FightAbility.ChanceToUseAbility())
                {
                    FightAbility.UseAbility(players[1]);
                }
                else
                {
                    AtackPlayer(players[1], players[0]);
                }
                Turn.ChangeTurn(ref turn);
            }
        }

        RestorePlayerStats(StatsBeforeFight, players[0], players[1]);

        ReturnPlayerToList(CheckWinner(players[0], players[1]));
    }
}