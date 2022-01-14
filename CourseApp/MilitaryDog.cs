namespace CourseApp
{
    using System;

    public class MilitaryDog : Dog
    {
        private string rank;
        private int militaryage = 0;

        public MilitaryDog(string name, int age, int weight, string rank, int militaryyears)
            : base(name, age, weight)
        {
            this.rank = rank;
            if (militaryyears > 0)
            {
                militaryage = militaryyears;
            }
        }

        public MilitaryDog(string name, int age, string rank, int militaryyears)
            : base(name, age)
        {
            this.rank = rank;
            if (militaryyears > 0)
            {
                militaryage = militaryyears;
            }
        }

        public string Jump()
        {
            return "*Jump*";
        }

        public string ImitDeath()
        {
            return "*lie down on the ground and close eyes*";
        }

        public string Attack()
        {
            return "*To attack someone*";
        }

        public new string GetAll()
        {
            string s;
            if (militaryage == 0)
            {
                s = "Invalid";
            }
            else
            {
                s = Convert.ToString(militaryage);
            }

            return $"{base.GetAll()}|Rank:{rank}|Militaryage:{s}";
        }
    }
}
