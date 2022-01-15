namespace CourseApp.Zoo.Interfaces
{
    using System.Collections.Generic;

    public interface IZoo
    {
        string Name { get; set; }

        List<IDrawable> Animals();

        List<IDrawable> People();

        List<IDrawable> Objects();
    }
}