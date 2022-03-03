namespace RpgSaga;
using RpgSaga.Players;

public class Logger
{
        public static void Greetings()
        {
            Console.WriteLine("Welcome to the RPG Saga!");
        }

        public static void ChoseGameMode()
        {
            Console.WriteLine("\nChose gamemode (Tournament or Deathmatch):");
        }

        public static void ChosePlayersCount()
        {
            Console.WriteLine("\nChoose how many heroes you want to create (power of two):");
        }

        public static void Turn(byte turn)
        {
            Console.WriteLine($"\nTurn {turn}:");
        }

        public static void Versus(Player player1, Player player2)
        {
            Console.WriteLine($"\n({player1.GetType().Name}) {player1.Name} vs ({player2.GetType().Name}) {player2.Name}");
        }

        public static void Attack(Player player1, Player player2, int damage)
        {
            Console.WriteLine($"({player1.GetType().Name}) {player1.Name} attack ({player2.GetType().Name}) {player2.Name} and deal {damage} damage");
        }

        public static void Attack(Player player1, Player player2, string? ability)
        {
            Console.WriteLine($"({player1.GetType().Name}) {player1.Name} use {ability} on ({player2.GetType().Name}) {player2.Name}");
        }

        public static void Attack(Player player1, Player player2, int damage, string? ability)
        {
            Console.WriteLine($"({player1.GetType().Name}) {player1.Name} attack ({player2.GetType().Name}) {player2.Name} with {ability} and deal {damage} damage");
        }

        public static void Death(Player player)
        {
            Console.WriteLine($"({player.GetType().Name}) {player.Name} is dead");
        }

        public static void End(Player player)
        {
            Console.WriteLine($"\nThe game is over. Winner is ({player.GetType().Name}) {player.Name}");
        }

        public static void PlayAgain()
        {
            Console.WriteLine("Do you want to play again? Y for Yes.");
        }
}
