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

    public override void UseAbility(List<Player> tournamentPair)
    {
            tournamentPair[0].Abilities[0].Active = false;
            tournamentPair[1].Buffs.Add(new FireArrows());
            Logger.Attack(tournamentPair[0], tournamentPair[1], this.Name);
    }

    public override void UseBuff(Player player)
    {
        player.HP -= 2;
    }
}