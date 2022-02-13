namespace RpgSaga.Players;
using RpgSaga.Abilities;
public class Archer : Player
{
    public Archer(string name)
    : base(name)
    {
        this.Abilities.Add(new FireArrows());
    }
}