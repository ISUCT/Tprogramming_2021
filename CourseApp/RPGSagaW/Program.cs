namespace RPGSagaW;
using RPGSagaW.Players;
using RPGSagaW.FightSystem;
internal class Program
{
    internal static void Main(string[] args)
    {
        Console.WriteLine("Hell");

        var p1 = new Archer("John", 5, 12);
        var p2 = new Knight("John", 5, 12);
        Console.WriteLine(p1.Health);

        while (p1.Health > 0)
        {
            Fight.AtackPlayer(p2, p1);
            Console.WriteLine(p1.Health);
        }

        var p3 = CreatePlayers.CreatePlayer();
        var p4 = CreatePlayers.CreatePlayer();
        Console.WriteLine($"{p3.Name} {p3.Damage} {p3.Health} {p3.GetType()}");
        Console.WriteLine($"{p4.Name} {p4.Damage} {p4.Health} {p4.GetType()}");

        Game game = new Game();
        game.StartGame();
    }
}