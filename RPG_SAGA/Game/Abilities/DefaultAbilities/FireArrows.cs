namespace RpgSaga.Abilities;
using RpgSaga.Players;
public class FireArrows : Ability
{
    public FireArrows()
    {
        this.Name = "Fire Arrows";
        this.Duration = 9999;
        this.Damage = 2;
    }

    public override void UseAbility(List<Player> tournamentPair, Logger log)
    {
        if (Active)
        {
            this.Active = false;
            tournamentPair[1].Buffs.Add(new FireArrows());
            log.Attack(tournamentPair[0], tournamentPair[1], this.Name);
        }
        else
        {
            Attack(tournamentPair, log);
        }
    }

    public override void UseBuff(Player player)
    {
        player.HP -= 2;
    }
}