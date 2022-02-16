namespace RPGSagaW.FightSystem;
using RPGSagaW.Players;

public static class Fight
{
    public static void AtackPlayer(Player attacker, Player getAttack)
    {
        getAttack.Health -= attacker.Damage;
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
            return p2;
        }
        else
        {
            return p1;
        }
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

        foreach (Player p in CreatePlayers.Players)
        {
            Console.WriteLine(p);
        }

        ReturnPlayerToList(CheckWinner(players[0], players[1]));
    }
}