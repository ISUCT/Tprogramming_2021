
using System.Collections.Generic;
using RpgSaga.PlayerAndClasses;

namespace RpgSaga.Game{
    public class CreatePlayers{
        public List<string> names = new List<string>();
        public List<Player> players = new List<Player>();

        bool checkPlayerName(string name){
            if(name.Length > 0){
                return true;
            }
            return false;
        }
        public string createPlayersNames(string name){
            if(checkPlayerName(name)){
                addPlayerNameToList(name);
                return name;
            }
            return "";
        }

        public void addPlayerNameToList(string name){
            names.Add(name);
        }

        int parseNumbers(string number){
            int intValue;
            bool checkValue = Int32.TryParse(number, out intValue);
            if(checkValue){
                return intValue;
            }
            return 0;
        }

        int checkNumberOfPlayers(int numOfPlayers){
            if(numOfPlayers % 2 == 0){
                return numOfPlayers;
            }
            return 0;
        }

        public int CreateNumberOfPlayers(string numOfPlayers){
            int parsedNumber = parseNumbers(numOfPlayers);

            if(parsedNumber != 0 && checkNumberOfPlayers(parsedNumber) != 0){
                return parsedNumber;
            }
            return 0;
        }

        public int generateRandomHealth(){
            Random rnd = new Random();
            return rnd.Next(18, 26);
        }

        public int generateRandomStrength(){
            Random rnd = new Random();
            return rnd.Next(6, 9);
        }

        public string chooseName(List<string> names){
            Random rnd = new Random();
            int randomName = rnd.Next(0, names.Count);
            string chosenName = names[randomName];
            names.RemoveAt(randomName);
            return chosenName;
        }

        public int chooseRandomClass(){
            Random rnd = new Random();
            return rnd.Next(1, 4);
        }
        
        public void createRandomPlayer(int numberOfPlayers, List<string> names){
            for(int i = 0; i < numberOfPlayers; i++){
                int health = generateRandomHealth();
                int strength = generateRandomStrength();
                string name = chooseName(names);
                int playerClass = chooseRandomClass();

                switch(playerClass){
                    case 1:
                        Player playerMage = new Mage(name, health, strength);
                        addPlayerToList(playerMage);
                        break;
                    case 2:
                        Player playerArcher = new Archer(name, health, strength);
                        addPlayerToList(playerArcher);
                        break;
                    case 3:
                        Player playerKnight = new Knight(name, health, strength);
                        addPlayerToList(playerKnight);
                        break;
                }
            }
        }

        public void addPlayerToList(Player p){
            players.Add(p);
        }
    }
}