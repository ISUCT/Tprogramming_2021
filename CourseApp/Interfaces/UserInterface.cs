namespace CourseApp.Interfaces {
    using System;
    using System.Collections.Generic;

    public class UserInterface {
        public void Draw(IDrawable obj) {
           Console.WriteLine(obj.Draw());
        }

        public void Draw(List<IDrawable> objects) {
            foreach (IDrawable obj in objects) {
                this.Draw(obj);
            }
        }
    }
}