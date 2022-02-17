
using RpgSaga.PlayerAndClasses;
using RpgSaga;

namespace RpgSaga.Game{
    public class Game{

        Logger log = new Logger();
        CreatePlayers createPlayers = new CreatePlayers();
        FightSystem fightSystem = new FightSystem();
        public List<Player> players;
        int turn;
        public void firstPart(){
            log.greetings();
            log.greetingsNumberOfPlayers();
            string? inputNumberOfPlayers = Console.ReadLine();
            int numberOfPlayers = createPlayers.CreateNumberOfPlayers(inputNumberOfPlayers);
            int copyNumberOfPlayers = 0;
            while(numberOfPlayers == 0){
                log.enteredWrongValueNumberOfPlayers();
                inputNumberOfPlayers = Console.ReadLine();
                numberOfPlayers = createPlayers.CreateNumberOfPlayers(inputNumberOfPlayers);
            }
            copyNumberOfPlayers += numberOfPlayers;

            while(numberOfPlayers != 0){
                log.addPlayerName(numberOfPlayers);
                string inputPlayerName = Console.ReadLine();
                string playerName = createPlayers.createPlayersNames(inputPlayerName);
                if(playerName.Length == 0){
                    log.enteredWrongValueNameOfPlayer();
                    inputPlayerName = Console.ReadLine();
                    playerName = createPlayers.createPlayersNames(inputPlayerName);
                }
                numberOfPlayers -= 1;
            }

            List<string> playerNames = createPlayers.names;
            createPlayers.createRandomPlayers(copyNumberOfPlayers, playerNames);

            players = createPlayers.players;
            log.successfullyCreatedPlayers(copyNumberOfPlayers);
            foreach(Player p in players){
                log.successfullyCreatedPlayersDescr(p);
            }
        }

        public void secondPart(){
            log.greetingsPlayersFight();
            int firstPlayer = fightSystem.choosePlayersForFight(players);
            int secondPlayer = fightSystem.choosePlayersForFight(players);
            int startHPp1 = players[firstPlayer].health;
            int startHPp2 = players[secondPlayer].health;
            while(secondPlayer == firstPlayer){
                secondPlayer = fightSystem.choosePlayersForFight(players);
            }

            log.chosenPlayersForFight(players[firstPlayer], players[secondPlayer]);

            int turn = fightSystem.firstTurn();

            bool playerDeath = false;
            while(!playerDeath){
                if(turn == 0){
                    int damage = fightSystem.makeDamage(players[firstPlayer], players[secondPlayer], turn);
                    log.turnToFightFirstPlayer(players[firstPlayer], players[secondPlayer], damage, "Normal Attack");
                    playerDeath = fightSystem.checkPlayerDeath(players[firstPlayer], players[secondPlayer]);
                    turn = 1;
                }
                else if(turn == 1){
                    int damage = fightSystem.makeDamage(players[firstPlayer], players[secondPlayer], turn);
                    log.turnToFightSecondPlayer(players[firstPlayer], players[secondPlayer], damage, "Normal Attack");
                    playerDeath = fightSystem.checkPlayerDeath(players[firstPlayer], players[secondPlayer]);
                    turn = 0;
                }
            }

            if(players[firstPlayer].health <= 0){
                log.playerIsDead(players[firstPlayer]);
                players[secondPlayer].health = startHPp2;
                players.RemoveAt(firstPlayer);
            }
            else{
                log.playerIsDead(players[secondPlayer]);
                players[firstPlayer].health = startHPp1;
                players.RemoveAt(secondPlayer);
            }

            if(players.Count == 1){
                log.endOfTheGameWinner(players[0]);
                return;
            }
        }
    }
}