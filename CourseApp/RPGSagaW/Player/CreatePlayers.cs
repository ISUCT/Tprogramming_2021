namespace RPGSagaW.Players;

public static class CreatePlayers
{
    private static List<Player> players = new List<Player>();

    private static List<string> names = new List<string>()
    {
        "Kirill",
        "Nikita",
        "Daniel",
    };

    private enum Classes
    {
        Archer,
        Knight,
        Wizard,
        Count,
    }

    public static List<Player> Players
    {
        get
        {
            return players;
        }
    }

    public static Player CreatePlayer()
    {
        int randomClass = Random.Shared.Next(0, (int)Classes.Count);

        switch (randomClass)
        {
            case 0:
                return new Archer(RandomName(), RandomDamage(), RandomHealth());
            case 1:
                return new Knight(RandomName(), RandomDamage(), RandomHealth());
            case 2:
                return new Wizard(RandomName(), RandomDamage(), RandomHealth());
            default:
                return new Archer(RandomName(), RandomDamage(), RandomHealth());
        }
    }

    public static void AddPlayerToList()
    {
        players.Add(CreatePlayer());
    }

    public static void AddPlayerToList(Player p)
    {
        players.Add(p);
    }

    private static string RandomName()
    {
        return names[Random.Shared.Next(0, names.Count)];
    }

    private static int RandomDamage()
    {
        return Random.Shared.Next(3, 6);
    }

    private static int RandomHealth()
    {
        return Random.Shared.Next(10, 26);
    }
}