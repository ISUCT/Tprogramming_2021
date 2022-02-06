namespace RpgSaga.Players;
using RpgSaga.Abilities;
public abstract class Player{
    public Player(){
        Random rnd = new Random();
        //this.Name = names[rnd.Next(names.Count)];
        this.HP = rnd.Next(12, 21);
        this.Strenght = rnd.Next(2, 6);
    }

    public List<string> names = new List<string>{
        "Nikita",
        "Kirill",
        "Denzel"};

    //public string Name { get; set; }
    public int HP { get; set; }
    public int Strenght { get; set; }
    
    public IAbility ability;

    public void UseAbility(){
        ability.Ability();
    }
    public void SetAbility(IAbility ability){
        this.ability = ability;
    }
}