namespace RpgSaga;
using RpgSaga.Players;
using System.Reflection;

public class Match
{
    private static List<Type> classes = Assembly.GetExecutingAssembly().GetTypes().Where(type => type.IsSubclassOf(typeof(Player))).ToList();

    private static List<Player> players = new List<Player>();

    private static List<string> names = new List<string>
    {
    "Nekit",
    "Kirill",
    "Denzel",
    "Rusik",
    };

    public static List<Player> CreatePlayers()
    {
        int playersCount;
        do
        {
            Console.WriteLine("Choose how many heroes you want to create (power of two):"); // перенести в логгер
            int.TryParse(Console.ReadLine(), out playersCount);
        }
        while (((playersCount & (playersCount - 1)) != 0) || (playersCount == 0));

        while (playersCount != 0)
        {
            var name = names[Random.Shared.Next(names.Count)];
            var hp = Random.Shared.Next(12, 20);
            var strenght = Random.Shared.Next(2, 6);
            object[] arguments = { name, hp, strenght };
            Player? nullable_instance = (Player?)Activator.CreateInstance(classes[Random.Shared.Next(classes.Count())], arguments);
            if (nullable_instance is not null)
            {
                players.Add(nullable_instance);
                playersCount--;
            }
        }

        return players;
    }

    public static List<List<Player>> CreateTournament()
    {
        List<List<Player>> tournamentBracket = new List<List<Player>>();
        while (players.Count != 0)
        {
            var player1 = players[Random.Shared.Next(players.Count)];
            players.Remove(player1);
            var player2 = players[Random.Shared.Next(players.Count)];
            players.Remove(player2);
            var tournamentPair = new List<Player>();
            tournamentPair.Add(player1);
            tournamentPair.Add(player2);
            tournamentBracket.Add(tournamentPair);
        }

        return tournamentBracket;
    }

    public static Player HostMatch(string gamemode)
    {
        Player winner;
        var players = CreatePlayers();
        switch (gamemode)
        {
            case "tournament":
                return winner = Match.Tournament();
            default:
                return winner = Match.Deathmatch();
        }
    }

    public static Player Deathmatch()
    {
        while (players.Count != 1)
        {
            var player1 = players[Random.Shared.Next(players.Count)];
            players.Remove(player1);
            var player2 = players[Random.Shared.Next(players.Count)];
            players.Remove(player2);
            List<Player> playersPair = new List<Player>();
            playersPair.Add(player1);
            playersPair.Add(player2);
            players.Add(Fight(playersPair));
        }

        return players[0];
    }

    public static Player Tournament()
    {
        byte turn = 0;

        do
        {
            turn++;
            Logger.Turn(turn);
            var tournamentBracket = CreateTournament();
            foreach (var tournamentPair in tournamentBracket)
            {
                players.Add(Fight(tournamentPair));
            }

            tournamentBracket.Clear();
            Console.ReadKey();
        }
        while (players.Count != 1);

        return players[0];
    }

    public static Player Fight(List<Player> playersPair) // В паре 0-Игрок всегда атакует, а 1-Игрок всегда "защищается"
    {
        int attack; // 0-default attack
        Logger.Versus(playersPair[0], playersPair[1]);
        while (playersPair.Count != 1)
        {
            for (int j = 0; j != 2; j++)
            {
                foreach (Player player in playersPair)
                {
                    player.RefreshBuffs(player);
                    if (!player.CheckAlive(player))
                    {
                        playersPair.Remove(player);
                        playersPair[0].ResetStats();
                        return playersPair[0];
                    }
                }

                if (playersPair[0].Buffs.Find(buff => buff.Stun) == null)
                {
                    var ability = playersPair[0].Abilities[0];
                    playersPair[0].Abilities.Remove(ability);
                    attack = Random.Shared.Next(0, 2);
                    if (attack == 0)
                    {
                        ability.Attack(playersPair);
                    }
                    else
                    {
                        ability.UseAbility(playersPair);
                    }

                    playersPair[0].Abilities.Add(ability);
                }

                if (!playersPair[1].CheckAlive(playersPair[1]))
                {
                    playersPair[0].ResetStats();
                    return playersPair[0];
                }

                Player temp = playersPair[0];
                playersPair[0] = playersPair[1];
                playersPair[1] = temp;
            }
        }

        playersPair[0].ResetStats();
        return playersPair[0];
    }
}