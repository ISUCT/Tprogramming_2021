namespace RpgSaga;
using RpgSaga.Abilities;
public class Program
{
    public static void Main(string[] args)
    {
        new Game();
        var Ability = new ability(true, typeof(FireArrows));
        Ability.Active = false;
    }
}