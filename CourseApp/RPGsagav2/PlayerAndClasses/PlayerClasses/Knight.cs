
namespace RpgSaga.PlayerAndClasses{
    public class Knight : Player{
        public Knight(string name, int health, int strength) : base(name, health, strength){
            abbility = new PowerShot();
        }
    }
}