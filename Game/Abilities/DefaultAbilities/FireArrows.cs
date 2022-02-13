namespace RpgSaga.Abilities;
using RpgSaga.Players;
public class FireArrows : Ability{
    public FireArrows(){
        this.name = "Fire Arrows";
        this.duration = 9999;
        this.damage = 2;
    }
    public override void useAbility(List<Player> tournamentPair, Logger log){
        if (active){
            this.active = false;
            tournamentPair[1].buffs.Add(new FireArrows());
            log.attack(tournamentPair[0], tournamentPair[1], this.name);
        }
        else{
            attack(tournamentPair, log);
        }
    }
    public override void useBuff(Player player)
    {
        player.hp -= 2;
    }
}