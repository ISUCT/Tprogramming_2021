using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFabric.abstracts
{
    public abstract class Animal : IAnimal
    {
        public bool IsFemale
        {
            get
            {
                return true;
            }
            set
            {
                throw new Exception("We'are the female!");
            }
        }

        public byte Age { get; set; }
        public float Weight { get; set; }
        public byte LifesCount { get; set; }
        public sbyte AgilityCount { get; set; }
        public byte EyeColor { get; set; }

        public abstract void Attack();

        public abstract byte GetFoodCount();
    }
}
