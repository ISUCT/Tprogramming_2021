
using RpgSaga;
using RpgSaga.PlayerAndClasses;
using RpgSaga.Game;

Player p = new Mage("Hell", 12, 12);
p.useAbbility();

Player pp = new Archer("Hell", 12, 12);
pp.useAbbility();

Player ppp = new Knight("Hell", 12, 12);
ppp.useAbbility();

CreatePlayers createPlayers = new CreatePlayers();

string inputNumberOfPlayers = Console.ReadLine();
int numberOfPlayers = createPlayers.CreateNumberOfPlayers(inputNumberOfPlayers);
int copyNumberOfPlayers = 0;
copyNumberOfPlayers += numberOfPlayers;
while(numberOfPlayers == 0){
    Console.WriteLine("You have entered the the wrong value! (it must be even and bigger than 0)");
    inputNumberOfPlayers = Console.ReadLine();
    numberOfPlayers = createPlayers.CreateNumberOfPlayers(inputNumberOfPlayers);
}

while(numberOfPlayers != 0){
    Console.WriteLine($"Add player name! {numberOfPlayers} left");
    string inputPlayerName = Console.ReadLine();
    string playerName = createPlayers.createPlayersNames(inputPlayerName);
    if(playerName.Length == 0){
        Console.WriteLine("You have entered wrong value! {it must be bigger than 0)");
        inputPlayerName = Console.ReadLine();
        playerName = createPlayers.createPlayersNames(inputPlayerName);
    }
    numberOfPlayers -= 1;
}

foreach(string name in createPlayers.names){
    Console.WriteLine(name);
}

createPlayers.createRandomPlayer(copyNumberOfPlayers, createPlayers.names);

for(int i = 0; i<createPlayers.players.Count; i++){
    Console.WriteLine(createPlayers.players[i]);
}

Console.WriteLine(p.name);
