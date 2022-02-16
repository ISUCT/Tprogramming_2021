namespace RPGSagaW.Players;

public abstract class Player
{
    public Player(string name, int damage, int health, Ability ability)
    {
        this.Name = name;
        this.Damage = damage;
        this.Health = health;
        this.PlayerAbility = ability;
        this.UsedAbility = false;
        this.Stun = false;
    }

    public double Damage { get; set; }

    public int Health { get; set; }

    public string? Name { get; set; }

    public bool UsedAbility { get; set; }
    public IAbility PlayerAbility { get; set; }

    public bool Stun { get; set; }
}