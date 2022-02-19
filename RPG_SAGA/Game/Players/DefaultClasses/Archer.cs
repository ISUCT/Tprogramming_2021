namespace RpgSaga.Players;
using RpgSaga.Abilities;
public class Archer : Player
{
    public Archer(string name, int hp, int strenght)
    : base(name, hp, strenght)
    {
        this.Abilities.Add(new FireArrows());
    }
}