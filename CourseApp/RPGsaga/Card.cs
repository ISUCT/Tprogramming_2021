namespace CourseApp.RPGsaga
{
    public class Card
    {
        public Card(Character player)
        {
            string abs = null;
            foreach (Ability a in player.Abilities)
            {
                abs += $"{a.Name}({a.Count})\n";
            }

            string bfs = null;
            foreach (Buff b in player.Buffs)
            {
                if (b.Type == "Buff")
                {
                    bfs += $"{b.Name}({b.Duration})\n";
                }
            }

            string dbfs = null;
            foreach (Buff b in player.Buffs)
            {
                if (b.Type == "Debuff")
                {
                    dbfs += $"{b.Name}({b.Duration})\n";
                }
            }

            Content = $"{(player.Dead ? "#[-Killed-]#" : "###########")}\n" +
                $"{player.Type}\n" +
                $"-----------\n" +
                $"{player.Name}\n" +
                $"-----------\n" +
                $"HP: {player.Healthpoints}/{player.MaxHealth}\n" +
                $"STR: {player.Strenght}\n" +
                $"-Abilities-\n" +
                $"{abs}" +
                $"---Buffs---\n" +
                $"{bfs}" +
                $"--Debuffs--\n" +
                $"{dbfs}" +
                $"###########";
        }

        public string Content { get; private set; }
    }
}
