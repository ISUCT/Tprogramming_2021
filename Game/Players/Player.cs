namespace RpgSaga.Players;
using RpgSaga.Abilities;
public abstract class Player{
    public Player(string name){
        Random rnd = new Random();
        this.name = name;
        this.hp = rnd.Next(12, 21);
        this.strenght = rnd.Next(2, 6);
        this.buffs = new List<Ability>();
        this.abilities = new List<Ability>();
        //this.abilities.Add(ability);
    }
    public List<Ability> abilities;
    public List<Ability> buffs;
    public string name { get; set; }
    public int hp { get; set; }
    public int strenght { get; set; }
}