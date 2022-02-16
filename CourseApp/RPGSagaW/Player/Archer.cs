namespace RPGSagaW.Players;

public class Archer : Player
{
    public Archer(string name, int damage, int health)
    : base(name, damage, health)
    {
        this.PlayerAbility = new FireArrows();
    }
}