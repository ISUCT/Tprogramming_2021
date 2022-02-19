namespace RpgSaga;
using RpgSaga.Players;
public class Game
{
    public Game()
    {
        Logger.Greetings();

        var players = CreatePlayers.Create();

        string? gamemode = "blank";
        while (gamemode != ("tournament" or "deathmatch"))
        {
            Logger.ChoseGameMode();
            gamemode = Console.ReadLine().ToLower();
        }

        Player winner;
        switch (gamemode)
        {
            case "tournament":
                var tournamentBracket = 
                winner = Battle(tournamentBracket);
                break;
            case "deathmatch":
                winner = Battle(players);
                break;
        }
        Logger.End(winner);
    }

    public Player Battle(List<Player> players)
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
            players.Add(FightSystem.Fight(playersPair));
        }
        return players[0];
    }

    public Player Battle(List<List<Player>> tournamentBracket)
    {
        return players[0];
    }

    //     var tournamentBracket = CreateTournament(players);
    //     var fs = new FightSystem();
    //     byte turn = 0;

    //     do
    //     {
    //         turn++;
    //         log.Turn(turn);
    //         while (players.Count != 0)
    //         {
    //             var player1 = players[Random.Shared.Next(players.Count)];
    //             players.Remove(player1);
    //             var player2 = players[Random.Shared.Next(players.Count)];
    //             players.Remove(player2);
    //             var tournamentPair = new List<Player>();
    //             tournamentPair.Add(player1);
    //             tournamentPair.Add(player2);
    //             tournamentBracket.Add(tournamentPair);
    //         }

    //         foreach (var tournamentPair in tournamentBracket)
    //         {
    //             players.Add(fs.Fight(tournamentPair, log));
    //         }

    //         tournamentBracket.Clear();
    //         Console.ReadKey();
    //     }
    //     while (players.Count != 1);
    //     log.End(players[0]);
    // }

    // public List<List<Player>> CreateTournament(List<Player> players)
    // {
    //     List<List<Player>> tournament = new List<List<Player>>();
    //     for (var pairs = 0; players.Count / 2 < pairs; pairs++)
    //     {
    //         tournament.Add(new List<Player>() { players[Random.Shared.Next(players.Count)], players[Random.Shared.Next(players.Count)] });
    //     }
        
    //     // players.Count/2 ;
    //     // return
    // }
}