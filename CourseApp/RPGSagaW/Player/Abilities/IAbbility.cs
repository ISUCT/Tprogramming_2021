namespace RPGSagaW.Players;

public interface IAbility
{
    string?AbilityName { get; set; }

    int IncreaseDamage { get; set; }

    bool Stun { get; set; }

    int Duration { get; set; }
}

public abstract class Ability : IAbility
{
    public Ability()
    {
    }

    public string?AbilityName { get; set; }

    public double IncreaseDamage { get; set; }

    public bool Stun { get; set; }

    public int Duration { get; set; }
}

public class FireArrows : Ability
{
    public FireArrows()
    {
        this.AbilityName = "Fire Arrows";
        this.IncreaseDamage = 2;
        this.Stun = false;
        this.Duration = 9999;
    }
}

public class Revenge : Ability
{
    public Revenge(Player p)
    {
        this.AbilityName = "Revenge";
        this.IncreaseDamage = p.Damage * 0.3;
        this.Stun = false;
        this.Duration = 1;
    }
}