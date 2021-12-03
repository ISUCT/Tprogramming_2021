
namespace RpgSaga.PlayerAndClasses{
    public class Mage : Player{       
        public Mage(string name, int health, int strength) : base(name, health, strength){
            abbility = new IceStun();
        }
    }
}