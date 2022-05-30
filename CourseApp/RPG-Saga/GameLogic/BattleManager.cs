namespace CourseApp.RPG_Saga.GameLogic
{
    using System;
    using System.Collections.Generic;
    using CourseApp.RPG_Saga.Interfaces;
    using CourseApp.RPG_Saga.Logger_;

    public static class BattleManager
    {
        public static void CheckPlayer(Player player)
        {
            List<IAbility> to_remove = new List<IAbility>();

            foreach (IAbility eff in player.Effects)
            {
                if (eff.CurrentDuration == 0)
                {
                    player.IsStunned = false;
                    to_remove.Add(eff);
                }
                else
                {
                    if (eff.IsStunning)
                    {
                        player.IsStunned = true;
                    }

                    if (eff.Damage != 0)
                    {
                        if (eff.DamageMultiplyer != 0)
                        {
                            player.Health -= Math.Round(eff.Damage * eff.DamageMultiplyer, 2);
                            player.RecivedDamage += Math.Round(eff.Damage * eff.DamageMultiplyer, 2);
                            Logger.GettingDamage(player.Name, player.RoleName, eff.Name, Math.Round(eff.Damage * eff.DamageMultiplyer, 2));
                        }
                        else
                        {
                        player.Health -= eff.Damage;
                        player.RecivedDamage += eff.Damage;
                        }
                    }

                    if (eff.DamagePerTurn != 0)
                    {
                        player.Health -= eff.DamagePerTurn;
                        player.RecivedDamage += eff.DamagePerTurn;
                        Logger.GettingDamage(player.Name, player.RoleName, eff.Name, eff.DamagePerTurn);
                    }

                    eff.CurrentDuration -= 1;
                }
            }

            {
                foreach (IAbility eff in to_remove)
                {
                player.Effects.Remove(eff);
                }
            }
        }
    }
}