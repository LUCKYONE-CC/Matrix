using Matrix;

namespace Sample
{
    public class Program
    {
        static void Main(string[] args)
        {
            var sample = new SimpleNumber(2);

            MatrixStructure<SimpleNumber> matrix = new MatrixStructure<SimpleNumber>(2, 2);
            matrix[0, 0] = sample;
            matrix[0, 1] = sample;
            matrix[1, 0] = sample;
            matrix[1, 1] = sample;

            MatrixStructure<SimpleNumber> matrix2 = new MatrixStructure<SimpleNumber>(2, 2);
            matrix2[0, 0] = sample;
            matrix2[0, 1] = sample;
            matrix2[1, 0] = sample;
            matrix2[1, 1] = sample;

            MatrixStructure<SimpleNumber> result = matrix * matrix2;
            result.PrintMatrix();
        }
    }
    public class SimpleNumber
    {
        public int Value { get; set; }
        public SimpleNumber()
        {
            
        }

        public SimpleNumber(int value)
        {
            Value = value;
        }
        public static SimpleNumber operator +(SimpleNumber a, SimpleNumber b)
        {
            return new SimpleNumber(a.Value + b.Value + 2);
        }
        public static SimpleNumber operator *(SimpleNumber a, SimpleNumber b)
        {
            return new SimpleNumber(a.Value * b.Value * 2);
        }
    }
}
