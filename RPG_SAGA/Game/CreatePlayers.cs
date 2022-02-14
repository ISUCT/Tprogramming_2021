namespace RpgSaga.Players;

public class CreatePlayers
{
    private List<Player> players = new List<Player>();

    private List<string> names = new List<string>
    {
    "Nikita",
    "Kirill",
    "Denzel",
    };

    public CreatePlayers()
    {
        List<Player> players = new List<Player>();
    }

    public void AddPlayerToList(Player player)
    {
        Console.WriteLine(player.Name);
        this.players.Add(player);
    }

    public List<Player> CreatePlayersList()
    {
        int playersCount;
        do
        {
            Console.WriteLine("Choose how many heroes you want to create. Enter an even number:");
            int.TryParse(Console.ReadLine(), out playersCount);
        }
        while ((playersCount > 1) && (playersCount % 2 != 0));

        Random rnd = new Random();
        int randomClassOfPlayer;
        string randomName;

        while (playersCount != 0)
        {
            randomClassOfPlayer = rnd.Next(0, 3);
            randomName = names[rnd.Next(names.Count)];

            switch (randomClassOfPlayer)
            {
                case 0:
                    AddPlayerToList(new Archer(randomName));
                    break;
                case 1:
                    AddPlayerToList(new Knight(randomName));
                    break;
                case 2:
                    AddPlayerToList(new Wizard(randomName));
                    break;
            }

            playersCount--;
        }

        return players;
    }
}