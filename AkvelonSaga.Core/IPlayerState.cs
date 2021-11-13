namespace AkvelonSaga.Core
{
    public interface IPlayerState
    {
        Player Player { get; }
        
        double Health { get; }

        void ApplyDamage(double damage);
    }
}
