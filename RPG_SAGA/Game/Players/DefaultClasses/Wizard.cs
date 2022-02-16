namespace RpgSaga.Players;
using RpgSaga.Abilities;
public class Wizard : Player
{
    public Wizard(string name, int hp, int strenght)
    : base(name, hp, strenght)
    {
        this.Abilities.Add(new Spellbound());
    }
}