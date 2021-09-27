namespace AkvelonSaga.Core
{
    public interface ISkill
    {
        void Apply(Player sender, Player target);
    }
}
