namespace CourseApp
{
    using System;

    public class Matrix : IMatrix
    {
        public Matrix(string matrix)
        {
            TypeOfMatrix = matrix;
        }

        public string TypeOfMatrix { get; set; }

        public string InstallMatrix(float diagonal)
        {
            Console.WriteLine($@"Installed Matrix: {(string.IsNullOrEmpty(TypeOfMatrix) ? "none" : TypeOfMatrix)} Diagonal: {diagonal}");
            return TypeOfMatrix;
        }
    }
}
