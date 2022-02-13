namespace RpgSaga.Players;
using RpgSaga.Abilities;
public class Wizard : Player{
    public Wizard(string name) : base(name){
        this.abilities.Add(new Spellbound());
    }
}