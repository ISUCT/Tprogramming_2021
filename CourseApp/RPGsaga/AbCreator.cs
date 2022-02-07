namespace CourseApp.RPGsaga
{
    using System.Collections.Generic;

    public class AbCreator
    {
        private List<Ability> abilities = new List<Ability>();

        public AbCreator()
        {
            abilities.Add(new Heal());
            abilities.Add(new ExtraHeal());
            abilities.Add(new FireArrow());
            abilities.Add(new FreezeRay());
            abilities.Add(new Revenge());
            abilities.Add(new SkipTurn());
            abilities.Add(new Bit());
            abilities.Add(new MaglFAr());
            abilities.Add(new Arrows());
        }

        public List<Ability> GetAbilities(string type)
        {
            List<Ability> abs = new List<Ability>();
            foreach (Ability b in abilities)
            {
                if (b.Type == "Every" || b.Type == type)
                {
                    abs.Add(b);
                }
            }

            return abs;
        }
    }
}
