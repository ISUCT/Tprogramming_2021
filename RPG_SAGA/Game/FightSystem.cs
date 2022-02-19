namespace RpgSaga;
using RpgSaga.Players;

public class FightSystem
{
    private int attack; // 0-default attack

    public static Player Fight(List<Player> tournamentPair) // В паре 0-Игрок всегда атакует, а 1-Игрок всегда "защищается"
    {
        Logger.Versus(tournamentPair[0], tournamentPair[1]);
        while (tournamentPair.Count != 1)
        {
            for (int j = 0; j != 2; j++)
            {
                foreach (Player player in tournamentPair)
                {
                    player.RefreshBuffs(player);
                    if (!player.CheckAlive(player))
                    {
                        tournamentPair.Remove(player);
                        return tournamentPair[0];
                    }
                }

                if (tournamentPair[0].Buffs.Find(buff => buff.Stun) == null)
                {
                    var ability = tournamentPair[0].Abilities[0];
                    tournamentPair[0].Abilities.Remove(ability);
                    attack = Random.Shared.Next(0, 2);
                    if (attack == 0)
                    {
                        ability.Attack(tournamentPair);
                    }
                    else
                    {
                        ability.UseAbility(tournamentPair);
                    }

                    tournamentPair[0].Abilities.Add(ability);
                }

                if (!tournamentPair[1].CheckAlive(tournamentPair[1]))
                {
                    return tournamentPair[0];
                }

                Player temp = tournamentPair[0];
                tournamentPair[0] = tournamentPair[1];
                tournamentPair[1] = temp;
            }
        }
        tournamentPair[0].ResetStats();
        return tournamentPair[0];
    }
}