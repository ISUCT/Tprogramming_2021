using AkvelonSaga.Core;

namespace AkvelonSaga.DLCs.Rogue.Roles
{
    public sealed class Mage : Player
    {
        public Mage(string name, double health, double attack) : base("Mage", name, health, attack)
        {
        }

        public static Mage Create(string name, double health, double attack)
        {
            return new(name, health, attack);
        }
    }
}
