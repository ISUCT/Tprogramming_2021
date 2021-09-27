namespace AkvelonSaga.Core
{
    public interface ISkill
    {
        void Apply(PlayerState sender, PlayerState target);
    }
}
