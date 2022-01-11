namespace CourseApp
{
    public interface IMatrix
    {
        string TypeOfMatrix { get; set; }

        string InstallMatrix(float diagonal);
    }
}