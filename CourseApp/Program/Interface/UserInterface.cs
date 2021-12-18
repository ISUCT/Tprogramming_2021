namespace CourseApp.Program.Interface
{
    using System.Collections.Generic;

    public class UserInterface
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
