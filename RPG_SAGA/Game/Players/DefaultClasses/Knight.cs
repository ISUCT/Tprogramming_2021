namespace RpgSaga.Players;
using RpgSaga.Abilities;
public class Knight : Player
{
    public Knight(string name)
    : base(name)
    {
        this.Abilities.Add(new VengeanceStrike());
    }
}