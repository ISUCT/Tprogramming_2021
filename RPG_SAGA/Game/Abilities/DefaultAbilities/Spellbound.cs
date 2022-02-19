namespace RpgSaga.Abilities;
using RpgSaga.Players;
public class Spellbound : Ability
{
    public Spellbound()
    {
        this.Name = "Spellbound";
        this.Duration = 1;
        this.Stun = true;
    }

    public override void UseAbility(List<Player> tournamentPair, Logger log)
    {
        if (Active)
        {
            tournamentPair[1].Buffs.Add(new Spellbound());
            Logger.Attack(tournamentPair[0], tournamentPair[1], this.Name);
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