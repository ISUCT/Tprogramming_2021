namespace RPGSagaW;
using RPGSagaW.Players;

public static class Logger
{
    public static void PlayerAttack(Player atacker, Player getAtack)
    {
        Console.WriteLine($"{atacker.Name} <{atacker.Health}HP> attacked {getAtack.Name} <{getAtack.Health}HP> with {atacker.Damage} damage");
    }

    public static void PlayerWin(Player p)
    {
        Console.WriteLine($"{p.Name} Won!");
    }
}