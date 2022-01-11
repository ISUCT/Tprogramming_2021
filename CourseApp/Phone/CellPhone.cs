namespace CourseApp
{
    using System;

    public abstract class CellPhone : Phone
    {
        public string DeclineCall()
        {
            return "Call declined";
        }

        public string SendText()
        {
            _ = Console.ReadLine();
            return "Message sent";
        }

        public string ReadText(string message)
        {
            return message;
        }
    }
}
