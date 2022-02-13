namespace RpgSaga.Abilities;
using RpgSaga.Players;
public class VengeanceStrike : Ability{
    public VengeanceStrike(){
        this.name = "VengeanceStrike";
    }
    public override void useAbility(List<Player> tournamentPair, Logger log){
        if (active){    
            int damage = (int)((tournamentPair[0].strenght + rnd.Next(0,5))*1.3);
            tournamentPair[1].hp -= damage;
            log.attack(tournamentPair[0], tournamentPair[1], damage, this.name);
        }
        else{
            attack(tournamentPair, log);
        }
    }
    public override void useBuff(Player player){}
}