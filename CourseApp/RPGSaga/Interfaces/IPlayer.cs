namespace CourseApp.RPGSaga.Interfaces
{
    using System.Collections.Generic;

    public interface IPlayer
    {
        string Name { get; set; }

        int HP { get; set; }

        int Strength { get; set; }

        void ApplyDamage(int damage);

        List<IAbility> Abilities();

        List<IAbility> Effects(IAbility effect);
    }
}