namespace CourseApp.Exam.Interfaces
{
    public interface IPhone
    {
        string Dial()
        {
            return "Making the call";
        }

        string AcceptCall()
        {
            return "Accepting the call";
        }
    }
}