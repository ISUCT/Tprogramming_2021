namespace AkvelonSaga.Core
{
    public interface ISkill
    {
        void Apply(IPlayerState sender, IPlayerState target);
    }
}
