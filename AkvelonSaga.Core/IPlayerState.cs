namespace AkvelonSaga.Core
{
    public interface IPlayerState
    {
        public Player Player { get; }
        
        public double Health { get; }

        public void ApplyDamage(double damage);
    }
}
