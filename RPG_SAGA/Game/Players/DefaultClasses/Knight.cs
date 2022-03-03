namespace RpgSaga.Players;
using RpgSaga.Abilities;
public class Knight : Player
{
    public Knight(string name, int hp, int strenght)
    : base(name, hp, strenght)
    {
        this.Abilities.Add(new ability(true, typeof(VengeanceStrike)));
    }
}