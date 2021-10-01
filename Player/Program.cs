using System;

namespace Player1
{
    interface IHasInfo
    {
        void ShowInfo();
    }
    interface IWeapon : IHasInfo
    {
        void Fire();
        int Damage { get; }
    }

    interface IThrowingWeapon : IWeapon
    {
        void Throw();
    }
    abstract class Weapon : IHasInfo, IWeapon
    {   
        public abstract int Damage { get; }
        public abstract void Fire();
        
        public void ShowInfo()
        {
            Console.WriteLine($"{GetType().Name} Damage: {Damage}"); 
        }
        
    }

    class Gun : Weapon
    {
        public override int Damage { get { return 10; } }

        public override void Fire()
        {
            Console.WriteLine("Puff");
        }
    }

    class LaserGun : Weapon
    {
        public override int Damage { get { return 20; } }

        public override void Fire()
        {
            Console.WriteLine("Phhh");
        }
    }

    class Bow : Weapon
    {
        public override int Damage { get { return 7; } }

        public override void Fire()
        {
            Console.WriteLine("Pow");
        }
    }

    class Knife : IThrowingWeapon
    {
        public int Damage => 7;

        public void Fire()
        {
            Console.WriteLine("Чиркнул ножом");
        }

        public void ShowInfo()
        {
            Console.WriteLine("Knife");
        }

        public void Throw()
        {
            Console.WriteLine("Бросил нож");
        }
    }

    class Box : IHasInfo
    {
        public void ShowInfo()
        {
            Console.WriteLine("is box");
        }

    }
    class Player
    {
        public void Fire(IWeapon weapon)
        {
            weapon.Fire();

        }

        public void CheckInfo(IHasInfo hasInfo)
        {
            hasInfo.ShowInfo();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            IWeapon[] inventory = { new Gun(), new LaserGun(), new Bow(), new Knife() };

            foreach (var item in inventory)
            {
                player.CheckInfo(item);
                player.Fire(item);
                Console.WriteLine();
            }
            player.CheckInfo(new Box());

                 
        }

    }
}
