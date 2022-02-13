namespace RpgSaga;
using RpgSaga.Players;

public class Game{
    public void startGame(){
        var log = new Logger();
        log.greetings();
        var cp = new CreatePlayers();
        var players = new List<Player>();
        players = cp.CreatePlayersList();
        var fs = new FightSystem();
        int turn = 1;

        do{
            log.turn(turn);
            players.Remove(fs.fight());
            Console.ReadKey();
        } while (players.Count != 1);
    }
}