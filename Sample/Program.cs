using Matrix;

namespace Sample
{
    public class Program
    {
        static void Main(string[] args)
        {
            MatrixStructure<int> matrix = new MatrixStructure<int>(2, 2);
            matrix[0, 0] = 2;
            matrix[0, 1] = 2;
            matrix[1, 0] = 2;
            matrix[1, 1] = 2;

            MatrixStructure<int> matrix2 = new MatrixStructure<int>(2, 2);
            matrix2[0, 0] = 2;
            matrix2[0, 1] = 2;
            matrix2[1, 0] = 2;
            matrix2[1, 1] = 2;

            MatrixStructure<int> result = matrix * matrix2;
            result.PrintMatrix();
        }
    }
}
