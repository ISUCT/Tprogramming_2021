namespace RpgSaga.Abilities;
using RpgSaga.Players;

public class ability
{
    public ability(bool active, Type abilitytype)
    {
        this.Active = active;
        this.AbilityType = abilitytype;
    }
    public bool Active { get; set; }
    public Type AbilityType { get; private set; }
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