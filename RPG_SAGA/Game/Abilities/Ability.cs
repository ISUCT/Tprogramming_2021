namespace RpgSaga.Abilities;
using RpgSaga.Players;

public abstract class Ability
{
    public Ability()
    {
        this.Active = true;
    }

    public string? Name { get; set; }

    public int Duration { get; set; }

    public int Damage { get; set; }

    public bool Stun { get; set; }

    public bool Active { get; set; }

    public abstract void UseAbility(List<Player> tournamentPair);

    public void Attack(List<Player> tournamentPair)
    {
        int damage = tournamentPair[0].Strenght + Random.Shared.Next(0, 5);
        tournamentPair[1].HP -= damage;
        Logger.Attack(tournamentPair[0], tournamentPair[1], damage);
    }

    public abstract void UseBuff(Player player);
}