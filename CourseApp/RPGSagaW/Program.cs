namespace RPGSagaW;
using RPGSagaW.Players;
using RPGSagaW.FightSystem;
internal class Program
{
    internal static void Main(string[] args)
    {
        Console.WriteLine("Hell");

        Game game = new Game();
        game.StartGame();
    }
}