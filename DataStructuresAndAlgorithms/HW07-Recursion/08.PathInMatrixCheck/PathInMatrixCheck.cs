using System;
using System.Collections.Generic;
using System.Linq;
namespace _08.PathInMatrixCheck
{
    using System.Text;
    using System.Threading.Tasks;

    public class PathInMatrixCheck
    {
        public static void Main()
        {
            char[,] matrix1 = new char[,] {
                                {'s', ' ', ' ', ' '},
                                {' ', '*', '*', ' '},
                                {' ', '*', '*', ' '},
                                {' ', '*', 'e', ' '},
                                {' ', ' ', ' ', ' '}
                             };

            char[,] matrix2 = new char[,] {
                                {'s', ' ', ' ', ' ', ' ', ' '},
                                {' ', '*', '*', ' ', '*', ' '},
                                {' ', '*', '*', ' ', '*', ' '},
                                {' ', '*', 'e', ' ', ' ', ' '},
                                {' ', ' ', ' ', '*', ' ', ' '}
                             };

            char[,] matrixEmpty = new char[100, 100];
            matrixEmpty[99, 99] = 'e';

            var m = new Matrix(matrixEmpty);
            m.FindPaths(0, 0, ' ');
        }
    }
}
