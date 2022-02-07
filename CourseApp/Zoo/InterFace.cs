namespace CourseApp.Zoo
{
    using System;
    using System.Collections.Generic;

    public class InterFace
    {
        public void Draw(IDraw obj)
        {
            Console.WriteLine(obj.Draw());
        }

        public void Draw(List<IDraw> objects)
        {
            foreach (IDraw obj in objects)
            {
                this.Draw(obj);
            }
        }
    }
}