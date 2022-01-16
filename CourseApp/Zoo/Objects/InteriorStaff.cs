namespace CourseApp.Zoo.Objects
{
    using CourseApp.Zoo.Interfaces;

    public class InteriorStaff : Staff, IDrawable
    {
        public InteriorStaff(string name, string type)
            : base(name, type)
        {
        }

        public string Draw()
        {
            return $"Object {Name} {Type} is situated at Zoo";
        }
    }
}