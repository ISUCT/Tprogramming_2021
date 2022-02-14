namespace RpgSaga;
using RpgSaga.Players;
public class Game
{
    public void StartGame()
    {
        var log = new Logger();
        log.Greetings();
        var cp = new CreatePlayers();
        var players = new List<Player>();
        players = cp.CreatePlayersList();
        var tournamentBracket = new List<List<Player>>();
        var fs = new FightSystem();
        Random rnd = new Random();
        int turn = 0;

        do
        {
            turn += 1;
            log.Turn(turn);
            while (players.Count != 0)
            {
                var player1 = players[rnd.Next(players.Count)];
                players.Remove(player1);
                var player2 = players[rnd.Next(players.Count)];
                players.Remove(player2);
                var tournamentPair = new List<Player>();
                tournamentPair.Add(player1);
                tournamentPair.Add(player2);
                tournamentBracket.Add(tournamentPair);
            }

            foreach (var tournamentPair in tournamentBracket)
            {
                players.Add(fs.Fight(tournamentPair, log));
                tournamentBracket.Remove(tournamentPair);
            }

            Console.ReadKey();
        }
        while (players.Count != 1);
        log.End(players[0]);
    }
}