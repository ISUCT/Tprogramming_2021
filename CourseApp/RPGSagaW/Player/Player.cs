namespace RPGSagaW.Players;

public abstract class Player
{
    public Player(string name, int damage, int health)
    {
        this.Name = name;
        this.Damage = damage;
        this.Health = health;
    }

    public int Damage { get; set; }

    public int Health { get; set; }

    public string? Name { get; set; }
}