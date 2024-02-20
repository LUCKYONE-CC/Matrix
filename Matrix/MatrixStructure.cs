namespace Matrix
{
    public class MatrixStructure<T>
    {
        private T[,] rawMatrix;

        public int Rows { get; private set; }
        public int Columns { get; private set; }
        public int Dimensions => Rows * Columns;

        public MatrixStructure(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            rawMatrix = new T[rows, columns];
        }
        public T this[int row, int column]
        {
            get
            {
                if (row >= 0 && row < Rows && column >= 0 && column < Columns)
                {
                    return rawMatrix[row, column];
                }
                throw new ArgumentOutOfRangeException("Row or column is out of range.");
            }
            set
            {
                if (row >= 0 && row < Rows && column >= 0 && column < Columns)
                {
                    rawMatrix[row, column] = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Row or column is out of range.");
                }
            }
        }
        public void PrintMatrix()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Console.Write(rawMatrix[i, j].ToString() + " ");
                }
                Console.WriteLine();
            }
        }
        public static MatrixStructure<T> operator *(MatrixStructure<T> a, MatrixStructure<T> b)
        {
            if(a.Columns != b.Rows)
                throw new InvalidOperationException("Invalid operation for this type.");

            MatrixStructure<T> result = new MatrixStructure<T>(a.Rows, b.Columns);

            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < b.Columns; j++)
                {
                    for (int k = 0; k < a.Columns; k++)
                    {
                        result[i, j] += (dynamic)a[i, k] * b[k, j];
                    }
                }
            }

            return result;
        }
        public static MatrixStructure<T> operator *(int a, MatrixStructure<T> b)
        {
            if (typeof(T) != typeof(double) && typeof(T) != typeof(int))
                throw new InvalidOperationException("Invalid operation for this type.");

            MatrixStructure<T> result = new MatrixStructure<T>(b.Rows, b.Columns);

            for (int i = 0; i < b.Rows; i++)
            {
                for (int j = 0; j < b.Columns; j++)
                {
                    result[i, j] = (dynamic)b[i, j] * a;
                }
            }

            return result;
        }
        public static MatrixStructure<T> operator *(MatrixStructure<T> a, int b)
        {
            return b * a;
        }
    }
}