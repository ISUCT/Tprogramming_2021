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
            IWeapon[] inventory = { new Gun(), new LaserGun(), new Bow() };

            foreach (var item in inventory)
            {
                player.CheckInfo(item);
                player.Fire(item);
                Console.WriteLine();
            }
            

                 
        }

    }
}
