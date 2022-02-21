using AnimalFabric.abstracts;

namespace AnimalFabric
{
    public class Mouse : Animal
    {
        public override void Attack()
        {
            Console.WriteLine("I'm on the attack!");
        }

        public override byte GetFoodCount()
        {
            return LifesCount;
        }
    }
}
