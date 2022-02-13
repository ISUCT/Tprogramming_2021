namespace RpgSaga.Abilities;
using RpgSaga.Players;

public abstract class Ability
{
    public Ability()
    {
        this.Name = "blank";
        this.Active = true;
    }

    public string Name { get; set; }

    public int Duration { get; set; }

    public int Damage { get; set; }

    public bool Stun { get; set; }

    public bool Active { get; set; }

    public Random Rnd { get; } = new Random();

    public abstract void UseAbility(List<Player> tournamentPair, Logger log);

    public void Attack(List<Player> tournamentPair, Logger log)
    {
        int damage = tournamentPair[0].Strenght + Rnd.Next(0, 5);
        tournamentPair[1].HP -= damage;
        log.Attack(tournamentPair[0], tournamentPair[1], damage);
    }

    public abstract void UseBuff(Player player);
}