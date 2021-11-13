using AkvelonSaga.Core;

namespace AkvelonSaga.Server.GameProcess
{
    public sealed class PlayerState : IPlayerState
    {
        public PlayerState(Player player)
        {
            Player = player;
            Health = player.Health;
        }

        public Player Player { get; }
        
        public double Health { get; private set; }

        public void ApplyDamage(double damage)
        {
            Health -= damage;
            
            if (Health < 0)
            {
                Health = 0;
            }
        }

        public override string ToString()
        {
            return Player.ToString();
        }
    }
}
