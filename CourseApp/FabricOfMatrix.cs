namespace CourseApp
{
    using System.Collections.Generic;

    public class FabricOfMatrix
    {
        private List<IMatrix> matrix = new List<IMatrix>();

        public void Matrixs(string typeOfMatrix)
        {
            matrix.Add(new Matrix(typeOfMatrix));
        }
    }
}
