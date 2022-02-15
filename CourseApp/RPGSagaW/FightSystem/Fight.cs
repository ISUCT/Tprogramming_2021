namespace RPGSagaW.FightSystem;
using RPGSagaW.Players;

public static class Fight
{
    public static void AtackPlayer(Player attacker, Player getAttack)
    {
        getAttack.Health -= attacker.Damage;
    }
}