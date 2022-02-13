namespace RpgSaga.Players;
using RpgSaga.Abilities;
public class Wizard : Player
{
    public Wizard(string name)
    : base(name)
    {
        this.Abilities.Add(new Spellbound());
    }
}