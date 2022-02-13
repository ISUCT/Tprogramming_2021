namespace RpgSaga.Players;
using RpgSaga.Abilities;
public abstract class Player{
    public Player(string name){
        Random rnd = new Random();
        this.name = name;
        this.maxhp = rnd.Next(12, 21);
        this.hp = this.maxhp;
        this.strenght = rnd.Next(2, 6);
        this.buffs = new List<Ability>();
        this.abilities = new List<Ability>();
    }
    public List<Ability> abilities;
    public List<Ability> buffs;
    public string name { get; set; }
    public int hp { get; set; }
    public int maxhp { get; set; }
    public int strenght { get; set; }
    public void resetStats(){
        hp = maxhp;
        buffs.Clear();
    }
    public bool checkAlive(){
        if (hp < 1){
            return false;
        }
        else{
            return true;
        }
    }
    public void refreshBuffs(Player player){
        foreach (var buff in buffs){
            if (buff.duration<1){
                buffs.Remove(buff);
            }
            else{
                buff.useBuff(player);
                buff.duration --;
            }
        }
    }
}