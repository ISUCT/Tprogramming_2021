namespace CourseApp.RPGSaga.Interfaces
{
    using System.Collections.Generic;

    public interface IPlayer
    {
        string Name { get; set; }

        int Hp { get; set; }

        int Strength { get; set; }

        bool IsFire { get; set; }

        bool IsDead { get; set; }

        void MakeAMove();

        void SetTarget(IPlayer enemy);

        void SetDamage();

        void AddEffect(IAbility effect);
    }
}