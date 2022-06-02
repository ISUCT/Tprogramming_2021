namespace RPGSagaW;
using RPGSagaW.Players;
using RPGSagaW.FightSystem;

public class Game
{
    public Game()
    {
    }

    public void StartGame()
    {
        CreatePlayersList(CreateNumberOfPlayers());
        while (CreatePlayers.Players.Count != 1)
        {
            Fight.StartFight(Fight.SelectPlayersForFight(CreatePlayers.Players));
        }

        Logger.WinnerOfGame(CreatePlayers.Players[0]);
    }

    private int CreateNumberOfPlayers()
    {
        int numberOfPlayers;
        while (int.TryParse(Console.ReadLine(), out numberOfPlayers) == false)
        {
            int.TryParse(Console.ReadLine(), out numberOfPlayers);
        }

        if (numberOfPlayers % 2 != 0)
        {
            return CreateNumberOfPlayers();
        }

        return numberOfPlayers;
    }

    private void CreatePlayersList(int numberOfPlayers)
    {
        while (numberOfPlayers != 0)
        {
            CreatePlayers.AddPlayerToList();
            numberOfPlayers -= 1;
        }
    }
}