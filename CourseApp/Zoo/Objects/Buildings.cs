namespace CourseApp.Zoo.Objects
{
    public class Buildings : Staff, IDrawable
    {
        public Buildings(string name, string type)
            : base(name, type)
        {
        }

        public string Draw()
        {
            return $"Building {Name} {Type} is situated at Zoo";
        }
    }
}