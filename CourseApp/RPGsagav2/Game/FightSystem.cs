
using RpgSaga.PlayerAndClasses;
using RpgSaga.Game;

namespace RpgSaga.Game{
    public class FightSystem{
        public int firstTurn(){
            Random rnd = new Random();
            return rnd.Next(0,2);
        }

        public int choosePlayersForFight(List<Player> players){
            Random rnd = new Random();
            return rnd.Next(0, players.Count);
        }

        public int makeDamage(Player p1, Player p2, int turn){
            Random rnd = new Random();
            int rndDamage = rnd.Next(1,4);
            int playerDamage = 0;
            int plusDamageOrMinusDamage = rnd.Next(0,2);
            if(turn == 0 && plusDamageOrMinusDamage == 0){
                playerDamage = p1.strength + rndDamage;
                p2.health -= playerDamage;
                return playerDamage;
            }
            else if(turn == 0 && plusDamageOrMinusDamage == 1){
                playerDamage = p1.strength - rndDamage;
                p2.health -= playerDamage;
                return playerDamage;
            }
            else if(turn == 1 && plusDamageOrMinusDamage == 0){
                playerDamage = p2.strength + rndDamage;
                p1.health -= playerDamage;
                return playerDamage;
            }
            else{
                playerDamage = p2.strength - rndDamage;
                p1.health -= playerDamage;
                return playerDamage;
            }
        }

        public bool chanceToUseAbbility(){
            Random rnd = new Random();
            int chance = rnd.Next(1,4);
            if(chance < 2){
                return false;
            }
            return true;
        }

        public bool checkPlayerDeath(Player p1, Player p2){
            if(p1.health <= 0 || p2.health <= 0){
                return true;
            }
            return false;
        }
    }
}