namespace CourseApp.Class
{
    using System;
    using System.Collections.Generic;

    public class ClassTask
    {
        public void GetCreatedFile(string name, string extension, double weight, string weightModificator)
        {
            Document file = new FileCreator(name, extension, weight, weightModificator);
            Console.WriteLine($"Your file: {file.Display()}");
        }

        public void GetDefaultFile()
        {
            Document file = new FileCreator();
            Console.WriteLine($"Default file: {file.Display()}");
        }
    }
}
