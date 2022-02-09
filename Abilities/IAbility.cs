namespace RpgSaga.Abilities;

public interface IAbility {
    string Damage_Buff { get;}
    string Strength_Buff { get;}
    string Name { get;}
    int Duration { get;}
    int Damage { get;}
    bool Stun { get;}
    void Ability();
}

public class FireArrows : IAbility{
    public FireArrows(){
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