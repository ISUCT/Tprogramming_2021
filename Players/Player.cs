namespace RpgSaga.Players;
using RpgSaga.Abilities;
public abstract class Player{
    public Player(Ability ability){
        Random rnd = new Random();
        this.name = names[rnd.Next(names.Count)];
        this.hp = rnd.Next(12, 21);
        this.strenght = rnd.Next(2, 6);
        this.buffs = new List<Ability>();
        this.abilities = new List<Ability>();
        this.abilities.Add(ability);
    }

    public List<string> names = new List<string>{
        "Nikita",
        "Kirill",
        "Denzel"};

    public List<Ability> abilities;
    public List<Ability> buffs;
    public string name { get; set; }
    public int hp { get; set; }
    public int strenght { get; set; }
    
}