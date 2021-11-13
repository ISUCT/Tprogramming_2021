using AkvelonSaga.Core;
using AkvelonSaga.DLCs.Rogue.Roles;
using AkvelonSaga.DLCs.Rogue.Skills;

namespace AkvelonSaga.DLCs.Rogue
{
    public class RoguePackage : IGamePackage
    {
        public void Configure(IPackageConfiguration configuration)
        {
            configuration.AddRole(nameof(Archer), Archer.Create);
            configuration.AddRole(nameof(Knight), Knight.Create);
            configuration.AddRole(nameof(Mage), Mage.Create);
            
            configuration.AddSkill<Archer, FireArrowsSkill>();
            configuration.AddSkill<Knight, RetaliationStrikeSkill>();
            configuration.AddSkill<Mage, BewitchingSkill>();
        }
    }
}
