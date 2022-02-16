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

    public static List<int> SavePlayerHealth(Player p1, Player p2)
    {
        List<int> health = new List<int>();
        health.Add(p1.Health);
        health.Add(p2.Health);
        return health;
    }

    public static void RestorePlayerHealth(List<int> health, Player p1, Player p2)
    {
        p1.Health = health[0];
        p2.Health = health[1];
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
        List<int> healthBeforeFight = SavePlayerHealth(players[0], players[1]);

        int turn = Turn.RandomFirstTurn();

        while (CheckPlayerDeath(players[0], players[1]))
        {
            if (turn == 0)
            {
                AtackPlayer(players[0], players[1]);
                Turn.ChangeTurn(ref turn);
            }
            else
            {
                AtackPlayer(players[1], players[0]);
                Turn.ChangeTurn(ref turn);
            }
        }

        RestorePlayerHealth(healthBeforeFight, players[0], players[1]);

        ReturnPlayerToList(CheckWinner(players[0], players[1]));
    }
}