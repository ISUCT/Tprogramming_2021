
namespace RpgSaga.PlayerAndClasses{
    public abstract class Player{

        public readonly string name;
        public int health;
        public int strength;
        public int damage;
        public Random rnd;

        public IAbbilities abbility;
        public void useAbbility(){
            abbility.abbility();
        }
        public void setAbbility(IAbbilities ab){
            abbility = ab;
        }

        public Player(string name, int health, int strength){
            this.name = name;
            this.health = health;
            this.strength = strength;
        }
    }
}