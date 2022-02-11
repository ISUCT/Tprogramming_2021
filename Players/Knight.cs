namespace RpgSaga.Players;
using RpgSaga.Abilities;
public class Knight : Player{
    public Knight() : base(){
        Ability ability = new FireArrows();
    }
}