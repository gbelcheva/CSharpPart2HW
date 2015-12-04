namespace P05_PathsBetweenCellsInMatrix
{
    using System;
    using System.Collections.Generic;

    public class PathsBetweenCellsInMatrix
    {
        private static char[,] matrix;
        private static int totalRows;
        private static int totalCols;
        private static List<char> directions = new List<char>();
        private static int totalPaths = 0;

        public static void Main(string[] args)
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

            matrix = matrix1;
            PrintArray(matrix);
            FindAllPaths(matrix);

            Console.WriteLine();
            totalPaths = 0;

            matrix = matrix2;
            PrintArray(matrix);
            FindAllPaths(matrix);
        }

        private static void PrintArray(char[,] matrix)
        {
            totalRows = matrix.GetLength(0);
            totalCols = matrix.GetLength(1);
            string bottomLine = new String('-', 2 * totalCols);

            Console.WriteLine(bottomLine);

            for (int i = 0; i < totalRows; i++)
            {
                for (int j = 0; j < totalCols; j++)
                {
                    Console.Write(string.Format("|{0}", matrix[i, j]));
                }

                Console.WriteLine("|" + Environment.NewLine + bottomLine);
            }
        }

        private static void FindAllPaths(char[,] matrix)
        {
            totalRows = matrix.GetLength(0);
            totalCols = matrix.GetLength(1);

            FindPath(0, 0, ' ');

            Console.WriteLine("Total paths found: {0}", totalPaths);
        }

        private static void FindPath(int row, int col, char dir)
        {
            if (col < 0 || row < 0 || col >= totalCols || row >= totalRows)
            {
                return;
            }

            if (matrix[row, col] == 'e')
            {
                directions.RemoveAt(0);
                directions.Add(dir);
                Console.WriteLine(string.Join("", directions));
                totalPaths++;
            }

            if (matrix[row, col] != ' ' && matrix[row, col] != 's')
            {
                return;
            }

            directions.Add(dir);
            matrix[row, col] = 'X';

            FindPath(row, col - 1, 'L');
            FindPath(row - 1, col, 'U');
            FindPath(row, col + 1, 'R');
            FindPath(row + 1, col, 'D');

            matrix[row, col] = ' ';
            directions.RemoveAt(directions.Count - 1);
        }
    }
}
