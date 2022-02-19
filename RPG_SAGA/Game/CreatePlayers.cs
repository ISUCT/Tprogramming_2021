namespace RpgSaga.Players;
using System.Reflection;

public class CreatePlayers
{
    private static List<Type> classes = Assembly.GetExecutingAssembly().GetTypes().Where(type => type.IsSubclassOf(typeof(Player))).ToList();
    
    private static List<Player> players = new List<Player>();

    private static List<string> names = new List<string>
    {
    "Nekit",
    "Kirill",
    "Denzel",
    "Rusik",
    };

    public static List<Player> Create()
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
<<<<<<< HEAD
            
            var hp = Random.Shared.Next(12,20);
            var strenght = Random.Shared.Next(2,6);
=======
            var hp = Random.Shared.Next(12, 20);
            var strenght = Random.Shared.Next(2, 6);
>>>>>>> 9f02ca2f78923b7982600338fe43fbd1c426129a
            object[] arguments = { name, hp, strenght };
            Player? nullable_instance = (Player?)Activator.CreateInstance(classes[Random.Shared.Next(classes.Count())], arguments);
            if (nullable_instance is not null)
            {
                players.Add(nullable_instance);
                playersCount--;
            }
        }
        return players;
    }
}