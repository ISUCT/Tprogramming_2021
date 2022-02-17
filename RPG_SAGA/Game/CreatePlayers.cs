namespace RpgSaga.Players;
using System.Reflection;
using RpgSaga.Players;

public class CreatePlayers
{
    private List<Player> players = new List<Player>();

    private List<string> names = new List<string>
    {
    "Nekit",
    "Kirill",
    "Denzel",
    "Rusik",
    };

    public CreatePlayers()
    {
        int playersCount;
        do
        {
            Console.WriteLine("Choose how many heroes you want to create. Enter an even number:");
            int.TryParse(Console.ReadLine(), out playersCount);
        }
        while ((playersCount > 1) && (playersCount % 2 != 0));

        while (playersCount != 0)
        {
            var name = names[Random.Shared.Next(names.Count)];
            var hp = Random.Shared.Next(12, 20);
            var strenght = Random.Shared.Next(2, 6);
            object[] arguments = { name, hp, strenght };
            List<Type> classes = Assembly.GetExecutingAssembly().GetTypes().Where(type => type.IsSubclassOf(typeof(Player))).ToList();
            Player? nullable_instance = (Player?)Activator.CreateInstance(classes[Random.Shared.Next(classes.Count())], arguments);
            if (nullable_instance is not null)
            {
                players.Add(nullable_instance);
                playersCount--;
            }
        }
    }

    public List<Player> ReturnPlayers()
    {
        return players;
    }
}