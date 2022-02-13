namespace RpgSaga.Abilities;
using RpgSaga.Players;
public class Spellbound : Ability{
    public Spellbound(){
        this.name = "Spellbound";
        this.duration = 1;
        this.stun = true;
    }
    public override void useAbility(List<Player> tournamentPair, Logger log){
        if (active){
            tournamentPair[1].buffs.Add(new Spellbound());
            log.attack(tournamentPair[0], tournamentPair[1], this.name);
        }
        else{
            attack(tournamentPair, log);
        }
    }
    public override void useBuff(Player player)
    {
        throw new NotImplementedException();
    }
}