namespace RpgSaga.Abilities;
using RpgSaga.Players;
public class VengeanceStrike : Ability
{
    public VengeanceStrike()
    {
        this.Name = "VengeanceStrike";
    }

    public override void UseAbility(List<Player> tournamentPair, Logger log)
    {
        if (Active)
        {
            int damage = (int)((tournamentPair[0].Strenght + Random.Shared.Next(0, 5)) * 1.3);
            tournamentPair[1].HP -= damage;
            log.Attack(tournamentPair[0], tournamentPair[1], damage, this.Name);
        }
        else
        {
            Attack(tournamentPair, log);
        }
    }

    public override void UseBuff(Player player)
    {
    }
}