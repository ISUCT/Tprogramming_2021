namespace RpgSaga;
using RpgSaga.Players;

public class Logger
{
        public void Greetings()
        {
            Console.WriteLine("Welcome to the RPG Saga!");
        }

        public void Turn(byte turn)
        {
            Console.WriteLine($"\nTurn {turn}:");
        }

        public void Versus(Player player1, Player player2)
        {
            Console.WriteLine($"(\n{player1.GetType().Name}) {player1.Name} vs ({player2.GetType().Name}) {player2.Name}");
        }

        public void Attack(Player player1, Player player2, int damage)
        {
            Console.WriteLine($"({player1.GetType().Name}) {player1.Name} attack ({player2.GetType().Name}) {player2.Name} and deal {damage} damage");
        }

        public void Attack(Player player1, Player player2, string ability)
        {
            Console.WriteLine($"({player1.GetType().Name}) {player1.Name} use {ability} on ({player2.GetType().Name}) {player2.Name}");
        }

        public void Attack(Player player1, Player player2, int damage, string ability)
        {
            Console.WriteLine($"({player1.GetType().Name}) {player1.Name} attack ({player2.GetType().Name}) {player2.Name} with {ability} and deal {damage} damage");
        }

        public void Death(Player player)
        {
            Console.WriteLine($"({player.GetType().Name}) {player.Name} is dead");
        }

        public void End(Player player)
        {
            Console.WriteLine($"\nThe game is over. Winner is ({player.GetType().Name}) {player.Name}");
        }
}
