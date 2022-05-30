namespace CourseApp.RPG_Saga
{
    using System;
    using System.Collections.Generic;
    using CourseApp.RPG_Saga.Interfaces;
    using CourseApp.RPG_Saga.Logger_;

    public abstract class Player
    {
        public string Name { get; set; }

        public string RoleName { get; set; }

        public double Health { get; set; }

        public double RecivedDamage { get; set; }

        public double Strenght { get; set; }

        public bool IsStunned { get; set; }

        public List<IAbility> Abilities { get; set; }

        public List<IAbility> Effects { get; set; }

        public void MakeMove(Player enemyPlayer)
        {
            Random rnd = new Random();

            if (!IsStunned)
            {
                if (rnd.Next(100) > 70)
                {
                    int index = rnd.Next(Abilities.Count);
                    if (Abilities[index].NumberOfUses > 0 || Abilities[index].NumberOfUses == -1)
                    {
                        List<IAbility> abilities = new List<IAbility>(Abilities);
                        enemyPlayer.Effects.Add(abilities[index]);
                        Abilities[index].NumberOfUses -= 1;
                        Logger.AbilityLog(Name, RoleName, enemyPlayer.Name, enemyPlayer.RoleName, Abilities[index].Name);
                        if (abilities[index].DoesWasteMove)
                        {
                            return;
                        }
                    }
                }

                ApplyDamage(enemyPlayer);
            }
            else
            {
                Logger.IsStunned(Name, RoleName);
                return;
            }
        }

        public void ApplyDamage(Player enemy)
        {
            enemy.Health -= Strenght;
            enemy.RecivedDamage += Strenght;
            Logger.DamageLog(Name, RoleName, enemy.Name, enemy.RoleName, Strenght);
        }

        public void Reset()
        {
            Health += RecivedDamage;
            RecivedDamage = 0;
            IsStunned = false;
            Effects.Clear();
            foreach (IAbility ability in Abilities)
            {
                ability.CurrentDuration = ability.BasicDuration;
                ability.NumberOfUses = ability.BasicNumberOfUses;
            }
        }
    }
}
