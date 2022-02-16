namespace RPGSagaW.FightSystem;
using RPGSagaW;
using RPGSagaW.Players;

public static class FightAbility
{
    public static bool CheckAbilityUse(Player p, bool abilityUsed)
    {
        if(abilityUsed == false)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool ChanceToUseAbility()
    {
        int chance = Random.Shared.Next(0, 8);
        if (chance > 5)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool UseAbility(Player p1, Player p2)
    {
            p1.Damage += p1.PlayerAbility.IncreaseDamage;
            p2.Stun = p1.PlayerAbility.Stun;
            Logger.UseAbility(p1);
            return true;
    }
}