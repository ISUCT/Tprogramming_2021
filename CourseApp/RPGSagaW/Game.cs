namespace RPGSagaW;
using RPGSagaW.Players;
using RPGSagaW.FightSystem;

public class Game
{
    public Game()
    {
    }

    private int createNumberOfPlayers()
    {
        int numberOfPlayers;
        while (int.TryParse(Console.ReadLine(), out numberOfPlayers) == false)
        {
            int.TryParse(Console.ReadLine(), out numberOfPlayers);
        }

        if (numberOfPlayers % 2 != 0)
        {
            return createNumberOfPlayers();
        }

        return numberOfPlayers;
    }

    private void createPlayersList()
    {
        int numberOfPlayers = createNumberOfPlayers();
        while (numberOfPlayers != 0)
        {
            CreatePlayers.AddPlayerToList();
            numberOfPlayers -= 1;
        }
    }

    public void StartGame()
    {
        createPlayersList();
        while(CreatePlayers.players.Count != 1)
        {
            Fight.StartFight(Fight.SelectPlayersForFight(CreatePlayers.players));
            Console.WriteLine(CreatePlayers.players.Count);
        }
    }
}