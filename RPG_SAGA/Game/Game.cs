namespace RpgSaga;
using RpgSaga.Players;
public class Game
{
    public void StartGame()
    {
        var log = new Logger();
        log.Greetings();
        var players = new CreatePlayers().ReturnPlayers();
        var tournamentBracket = CreateTournament(players);
        var fs = new FightSystem();
        byte turn = 0;

        // do
        // {
        //     turn++;
        //     log.Turn(turn);
        //     while (players.Count != 0)
        //     {
        //         var player1 = players[Random.Shared.Next(players.Count)];
        //         players.Remove(player1);
        //         var player2 = players[Random.Shared.Next(players.Count)];
        //         players.Remove(player2);
        //         var tournamentPair = new List<Player>();
        //         tournamentPair.Add(player1);
        //         tournamentPair.Add(player2);
        //         tournamentBracket.Add(tournamentPair);
        //     }

        //     foreach (var tournamentPair in tournamentBracket)
        //     {
        //         players.Add(fs.Fight(tournamentPair, log));
        //     }

        //     tournamentBracket.Clear();
        //     Console.ReadKey();
        // }
        // while (players.Count != 1);
        // log.End(players[0]);
    }

    public List<List<Player>> CreateTournament(List<Player> players)
    {
        List<List<Player>> tournament = new List<List<Player>>();
        for (var pairs = 0; players.Count/2<pairs; pairs++)
        {
            tournament.Add(new List<Player>({ players[Random.Shared.Next(players.Count)], players[Random.Shared.Next(players.Count)]}));
        }
        players.Count/2 ;
        return
    }
}