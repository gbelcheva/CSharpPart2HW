namespace HW12Refactoring
{
    using System;

    public class TestMatrix
    {
        public static void Main(string[] args)
        {
            var matrix = new Matrix(5);

            matrix.FillMatrix();

            Console.WriteLine(matrix);
        }
    }
}
