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

    public static void WinnerOfGame(Player p)
    {
        Console.WriteLine($"{p.Name} Won the Game!");
    }

    public static void UseAbility(Player p)
    {
        Console.WriteLine($"{p.Name} used {p.PlayerAbility.AbilityName}");
    }
}