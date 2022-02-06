// using RpgSaga.PlayerAndClasses;
// using RpgSaga.Game;

// namespace RpgSaga{
//     public class Logger{
//         public void greetings(){
//             Console.WriteLine("Hello stranger! Welcome to the RPGsaga! Now you have to create even number of characters and choose their names!");
//         }

//         public void greetingsNumberOfPlayers(){
//             Console.WriteLine("\nEnter number of charaters");
//         }

//         public void enteredWrongValueNumberOfPlayers(){
//             Console.WriteLine("\nYou have entered the the wrong value! (it must be even and bigger than 0)");
//         }

//         public void addPlayerName(int numberOfPlayers){
//             Console.WriteLine($"\nAdd player name! {numberOfPlayers} left");
//         }

//         public void enteredWrongValueNameOfPlayer(){
//             Console.WriteLine("You have entered wrong value! (it must be bigger than 0)");
//         }

//         public void successfullyCreatedPlayers(int numberOfPlayers){
//             Console.WriteLine($"\nYou have successfully created {numberOfPlayers} character");
//         }

//         public void successfullyCreatedPlayersDescr(Player p){
//             Console.WriteLine($"{p.name}: {p.GetType().Name}, health: {p.health}, strenght: {p.strength}");
//         }

//         public void greetingsPlayersFight(){
//             Console.WriteLine("\nNow two players will be randomly chosen");
//         }

//         public void chosenPlayersForFight(Player p1, Player p2){
//             Console.WriteLine($"\nTheir names are {p1.name}, {p2.name}");
//         }

//         public void turnToFightFirstPlayer(Player p1, Player p2, int damage, string typeOfAttack){
//             Console.WriteLine($"\n{p1.name} hits {p2.name} with ({typeOfAttack}) and deals {damage} damage");
//         }

//         public void turnToFightSecondPlayer(Player p1, Player p2, int damage, string typeOfAttack){
//             Console.WriteLine($"\n{p2.name} hits {p1.name} with ({typeOfAttack}) and deals {damage} damage");
//         }

//         public void playerIsDead(Player p){
//             Console.WriteLine($"\nCharacter {p.name} is dead!");
//         }

//         public void endOfTheGameWinner(Player p){
//             Console.WriteLine($"\nThe winner is {p.name}!");
//         }
//     }
// }