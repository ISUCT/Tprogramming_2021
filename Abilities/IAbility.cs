namespace RpgSaga.Abilities;

abstract public class Ability {

    public Ability (int damage_buff, int strenght_buff, string name, int duration, int damage, bool stun){

    }
    private int damage_buff;
    private int strength_buff;
    private string name;
    private int duration;
    private int damage;
    private bool stun;
    private void Ability();
}

public class FireArrows : Ability{
    public FireArrows() : base(){
        this.Name = "Fire Arrows";
        this.Duration = 9999;
        this.Damage = 2;
        this.Stun = false;
        this.Damage_Buff = "Fire Arrows";
        this.Strength_Buff = "Fire Arrows";
    }
    public string Damage_Buff { get;}
    public string Strength_Buff { get;}
    public string Name { get;}
    public int Duration { get;}
    public int Damage { get;}
    public bool Stun { get;}
    public void Ability(){
        Console.WriteLine($"{this.Name}");
    }
}