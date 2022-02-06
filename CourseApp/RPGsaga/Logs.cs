namespace CourseApp.RPGsaga
{
    using System;
    using System.Collections.Generic;

    public static class Logs
    {
        private static List<string> logRows = new List<string>();

        public static Ability LastAbility { get; private set; }

        public static void AddLogRowAbilityUse(Character from, Character to, Ability ab)
        {
            string buffs = null;
            foreach (Buff b in ab.GetBuffs())
            {
                buffs += $"{b.Name} ";
            }

            logRows.Add($"{from.Name}({from.Type})----{ab.Name}---->{to.Name}({to.Type}) [Damage: {(int)(ab.Damage * (from.Strenght / 10) * from.Scale)} | Buffs/Debuffs: {buffs}]\n");
            LastAbility = ab;
        }

        public static void AddLogRowDeath(Character killer, Character dead)
        {
            try
            {
                logRows.Add($"{killer.Name}({killer.Type}) kills {dead.Name}({dead.Type})\n");
            }
            catch (Exception e)
            {
               Console.WriteLine(e.Message);
            }
        }

        public static List<string> GetLogs()
        {
            return logRows;
        }
    }
}
