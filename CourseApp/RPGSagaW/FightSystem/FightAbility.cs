namespace RPGSagaW.FightSystem;
using RPGSagaW;
using RPGSagaW.Players;

public static class FightAbility
{
    public static bool CheckAbilityUse(Player p, bool abilityUsed)
    {
        if(abilityUsed == false)
        {
            p.UsedAbility = true;
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

    public static bool UseAbility(Player p)
    {
            p.Damage += p.PlayerAbility.IncreaseDamage;
            p.Stun = p.PlayerAbility.Stun;
            Logger.UseAbility(p);
            return true;
    }
}