using AkvelonSaga.Core;

namespace AkvelonSaga.DLCs.Rogue.Roles
{
    public sealed class Archer : Player
    {
        public Archer(string name, double health, double attack) : base("Archer", name, health, attack)
        {
        }

        public static Archer Create(string name, double health, double attack)
        {
            return new(name, health, attack);
        }
    }
}
