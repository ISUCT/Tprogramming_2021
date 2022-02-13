namespace RpgSaga.Abilities;
using RpgSaga.Players;

abstract public class Ability {
    public Ability(){
        this.name = "blank";
    }
    public string name { get; set; }
    public int duration { get; set; }
    public int damage { get; set; }
    public bool stun { get; set; }
    public bool active = true;
    public Random rnd = new Random();
    public abstract void useAbility(List<Player> tournamentPair, Logger log);
    public void attack(List<Player> tournamentPair, Logger log){
        int damage = tournamentPair[0].strenght + rnd.Next(0,5);
        tournamentPair[1].hp -= damage;
        log.attack(tournamentPair[0], tournamentPair[1], damage);  
    }
    public abstract void useBuff(Player player);
}