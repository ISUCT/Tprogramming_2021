namespace RpgSaga;
using RpgSaga.Players;
public class Game
{
    public Game()
    {
        List<string> gamemodes = new List<string>
        {
        "tournament",
        "deathmatch",
        };

        Logger.Greetings();
        while (true)
        {
            string? gamemode;
            while (true)
            {
                Logger.ChoseGameMode();
                gamemode = Console.ReadLine();
                gamemode = gamemode != null ? gamemode.ToLower() : "blank";
                if (gamemodes.Contains(gamemode))
                {
                    break;
                }
            }

            if (gamemode != null)
            {
                Logger.End(Match.HostMatch(gamemode));
            }

            Logger.PlayAgain();
            if (Console.ReadKey(true).Key != ConsoleKey.Y)
            {
                Environment.Exit(0);
            }
        }
    }
}