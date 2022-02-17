
namespace RpgSaga.PlayerAndClasses{
    public class Archer : Player{
        public Archer(string name, int health, int strength) : base(name, health, strength){
            abbility = new FireArrows();
        }
    }
}