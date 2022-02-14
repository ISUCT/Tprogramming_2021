namespace RpgSaga;
using RpgSaga.Players;

public class FightSystem
{
    private Random rnd = new Random();
    private int attack; // 0-default attack

    public Player Fight(List<Player> tournamentPair, Logger log)
    {
        foreach (Player player in tournamentPair)
        {
            player.ResetStats();
        }

        log.Versus(tournamentPair[0], tournamentPair[1]);
        while (tournamentPair.Count != 1)
        {
            for (int j = 0; j != 2; j++)
            {
                foreach (Player player in tournamentPair)
                {
                    player.RefreshBuffs(player);
                    if (!player.CheckAlive(player, log))
                    {
                        tournamentPair.Remove(player);
                        return tournamentPair[0];
                    }
                }

                if (tournamentPair[0].Buffs.Find(buff => buff.Stun) == null)
                {
                    var ability = tournamentPair[0].Abilities[0];
                    tournamentPair[0].Abilities.Remove(ability);
                    attack = rnd.Next(0, 2);
                    if (attack == 0)
                    {
                        ability.Attack(tournamentPair, log);
                    }
                    else
                    {
                        ability.UseAbility(tournamentPair, log);
                    }

                    tournamentPair[0].Abilities.Add(ability);
                }

                if (!tournamentPair[1].CheckAlive(tournamentPair[1], log))
                {
                    return tournamentPair[0];
                }

                Player temp = tournamentPair[0];
                tournamentPair[0] = tournamentPair[1];
                tournamentPair[1] = temp;
            }
        }

        return tournamentPair[0];
    }
}