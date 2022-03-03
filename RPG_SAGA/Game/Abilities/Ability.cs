namespace RpgSaga.Abilities;
using RpgSaga.Players;

public struct ability
{
    public ability(bool active, Type abilitytype)
    {
        this.Active = active;
        this.AbilityType = abilitytype;
    }
    bool Active;
    Type AbilityType;
}

public abstract class Ability
{
    public Ability()
    {
    }

    public string? Name { get; set; }

    public int Duration { get; set; }

    public int Damage { get; set; }

    public bool Stun { get; set; }

    public abstract void UseAbility(List<Player> tournamentPair);

    public abstract void UseBuff(Player player);
}