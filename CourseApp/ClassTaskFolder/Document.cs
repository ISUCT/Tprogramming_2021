namespace CourseApp.Class
{
    using System;

    public abstract class Document : Exception
    {
        private string _name;

        public Document(string name)
        {
            Name = name;
        }

        public Document()
        {
            Name = "Program";
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                CheckValues.CheckValueForNullEmptyOrWhiteSpace(value);
                _name = value;
            }
        }

        public abstract string Display();
    }
}