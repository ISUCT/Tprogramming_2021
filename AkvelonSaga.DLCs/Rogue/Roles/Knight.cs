using AkvelonSaga.Core;

namespace AkvelonSaga.DLCs.Rogue.Roles
{
    public sealed class Knight : Player
    {
        public Knight(string name, double health, double attack) : base("Knight", name, health, attack)
        {
        }

        public static Knight Create(string name, double health, double attack)
        {
            return new(name, health, attack);
        }
    }
}
