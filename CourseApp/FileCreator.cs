namespace CourseApp
{
    using System;
    using static System.Math;

    public class FileCreator
    {
        public FileCreator(string filename, string extension, double weight, string weightModificator)
        {
            FileName = filename;
            Extension = extension;
            Weight = weight;
            WeightModificator = weightModificator;
        }

        public string FileName { get; set; }

        public string Extension { get; set; }

        public double Weight { get; set; }

        public string WeightModificator { get; set; }

        public string Display()
        {
            return $"{FileName}{Extension} {Weight}{WeightModificator}";
        }
    }
}