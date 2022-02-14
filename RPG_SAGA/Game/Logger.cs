namespace RpgSaga;
using RpgSaga.Players;

public class Logger
{
        public void Greetings()
        {
            Console.WriteLine("Welcome to the RPG Saga!");
        }

        public void Turn(int turn)
        {
            Console.WriteLine();
            Console.WriteLine($"Turn {turn}:");
        }

        public void Versus(Player player1, Player player2)
        {
            Console.WriteLine($"({player1.GetType}) {player1.Name} vs ({player2.GetType}) {player2.Name}");
        }

        public void Attack(Player player1, Player player2, int damage)
        {
            Console.WriteLine($"({player1.GetType}) {player1.Name} Attack ({player2.GetType}) {player2.Name} and deal {damage} damage");
        }

        public void Attack(Player player1, Player player2, string ability)
        {
            Console.WriteLine($"({player1.GetType}) {player1.Name} use {ability} on ({player2.GetType}) {player2.Name}");
        }

        public void Attack(Player player1, Player player2, int damage, string ability)
        {
            Console.WriteLine($"({player1.GetType}) {player1.Name} attack ({player2.GetType}) {player2.Name} with {ability} and deal {damage} damage");
        }

        public void Death(Player player)
        {
            Console.WriteLine($"({player.GetType}) {player.Name} is dead");
            Console.WriteLine();
        }

        public void End(Player player)
        {
            Console.WriteLine($"The game is over. Winner is ({player.GetType}) {player.Name}");
        }
}
