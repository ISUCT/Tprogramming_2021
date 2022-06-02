namespace RPGSagaW.Players;

public class Wizard : Player
{
    public Wizard(string name, int damage, int health)
    : base(name, damage, health)
    {
        this.PlayerAbility = new Stun();
    }
}