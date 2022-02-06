namespace RpgSaga.Abilities;

public interface IAbility{
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
    }
    public string Name { get;}
    public int Duration { get;}
    public int Damage { get;}
    public bool Stun { get;}
    public void Ability(){
        Console.WriteLine($"{this.Name}");
    }
}