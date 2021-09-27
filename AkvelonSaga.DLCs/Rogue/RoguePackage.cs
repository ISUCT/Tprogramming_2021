using AkvelonSaga.Core;
using AkvelonSaga.DLCs.Rogue.Roles;

namespace AkvelonSaga.DLCs.Rogue
{
    public class RoguePackage : IGamePackage
    {
        public void Configure(IPackageConfiguration configuration)
        {
            configuration.AddRole(nameof(Archer), Archer.Create);
            configuration.AddRole(nameof(Knight), Knight.Create);
            configuration.AddRole(nameof(Mage), Mage.Create);
        }
    }
}
