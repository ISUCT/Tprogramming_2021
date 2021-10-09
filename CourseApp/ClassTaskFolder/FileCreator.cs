namespace CourseApp.Class
{
    using System;
    using static System.Math;

    public class FileCreator : Document
    {
        private string _extension;
        private double _weight;
        private string _weightModificator;

        public FileCreator(string name, string extension, double weight, string weightModificator)
        : base(name)
        {
            Name = name;
            Extension = extension;
            Weight = weight;
            WeightModificator = weightModificator;
        }

        public FileCreator()
        : base()
        {
            Extension = ".cs";
            Weight = 0.45;
            WeightModificator = "B";
        }

        public string Extension
        {
            get
            {
                return _extension;
            }

            set
            {
                CheckValues.CheckValueForNullEmptyOrWhiteSpace(value);
                _extension = value;
            }
        }

        public double Weight
        {
            get
            {
                return _weight;
            }

            set
            {
                CheckValues.CheckValueForNullEmptyOrWhiteSpace(value);
                _weight = value;
            }
        }

        public string WeightModificator
        {
            get
            {
                return _weightModificator;
            }

            set
            {
                CheckValues.CheckValueForNullEmptyOrWhiteSpace(value);
                _weightModificator = value;
            }
        }

        public override string Display()
        {
            Console.Clear();
            return $"{Name}{Extension} {Weight}{WeightModificator}";
        }
    }
}