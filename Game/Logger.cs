namespace RpgSaga;
using RpgSaga.Players;

public class Logger{
        public void greetings(){
            Console.WriteLine("Welcome to the RPG Saga!");
        }
        public void turn(int turn){
            Console.WriteLine($"Turn {turn}:");
        }
        public void versus(Player player1, Player player2){
            Console.WriteLine($"({player1.GetType}) {player1.name} vs ({player2.GetType}) {player2.name}");
        }
        public void attack(Player player1, Player player2, int damage){
            Console.WriteLine($"({player1.GetType}) {player1.name} attack ({player2.GetType}) {player2.name} and deal {damage} damage");
        }
        public void attack(Player player1, Player player2, string ability){
            Console.WriteLine($"({player1.GetType}) {player1.name} use {ability} on ({player2.GetType}) {player2.name}");
        }
        public void attack(Player player1, Player player2, int damage, string ability){
            Console.WriteLine($"({player1.GetType}) {player1.name} attack ({player2.GetType}) {player2.name} with {ability} and deal {damage} damage");
        }
        public void death(Player player){
            Console.WriteLine($"({player.GetType}) {player.name} is dead");
        }
        public void end(Player player){
            Console.WriteLine($"The game is over. Winner is ({player.GetType}) {player.name}");
        }
}
