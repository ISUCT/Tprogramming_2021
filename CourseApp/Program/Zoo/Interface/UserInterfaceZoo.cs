namespace CourseApp
{
    using System.Collections.Generic;

    public class UserInterfaceZoo
    {
        public void Draw(IDrawable obj)
        {
            obj.Draw();
        }

        public void Draw(List<IDrawable> objects)
        {
            foreach (IDrawable obj in objects)
            {
                this.Draw(obj);
            }
        }
    }
}
