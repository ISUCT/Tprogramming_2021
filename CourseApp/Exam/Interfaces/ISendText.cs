namespace CourseApp.Exam.Interfaces
{
    using System;

    public interface ISendText
    {
        string SendText()
        {
            var massage = Console.ReadLine();
            return $"Massage {massage} was sent";
        }
    }
}