namespace P06_ConnectedAreasInMatrix
{
    using System;
    using System.Collections.Generic;

    public class ConnectedAreasInMatrix
    {
        private static char[,] matrix;
        private static ConnectedArea currentConnectedArea;
        private static SortedSet<ConnectedArea> connectedAreas = new SortedSet<ConnectedArea>();

        public static void Main(string[] args)
        {
            char[,] matrix1 = new char[,]
            {
                {' ', ' ', ' ', '*', ' ', ' ', ' ', '*', ' '},
                {' ', ' ', ' ', '*', ' ', ' ', ' ', '*', ' '},
                {' ', ' ', ' ', '*', ' ', ' ', ' ', '*', ' '},
                {' ', ' ', ' ', ' ', '*', ' ', '*', ' ', ' '}             
            };
            char[,] matrix2 = new char[,]
            {
                {'*', ' ', ' ', '*', ' ', ' ', ' ', '*', ' ', ' '},
                {'*', ' ', ' ', '*', ' ', ' ', ' ', '*', ' ', ' '},
                {'*', ' ', ' ', '*', '*', '*', '*', '*', ' ', ' '},
                {'*', ' ', ' ', '*', ' ', ' ', ' ', '*', ' ', ' '},
                {'*', ' ', ' ', '*', ' ', ' ', ' ', '*', ' ', ' '}   
            };

            matrix = matrix1;
            PrintArray(matrix);

            TraverseAllAreas();
            PrintResult();

            Console.WriteLine();

            matrix = matrix2;
            PrintArray(matrix);
            currentConnectedArea = null;
            connectedAreas.Clear();

            TraverseAllAreas();
            PrintResult();
        }

        private static void PrintResult()
        {
            Console.WriteLine("Total areas found: {0}", connectedAreas.Count);
            Console.WriteLine(string.Join("\n", connectedAreas));
        }

        private static void PrintArray(char[,] matrix)
        {
            int totalRows = matrix.GetLength(0);
            int totalCols = matrix.GetLength(1);
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

        private static void TraverseAllAreas()
        {
            if (!FindFirstTraversableCell(matrix))
            {
                return;
            }

            FindFirstTraversableCell(matrix);
            TraverseArea(currentConnectedArea.Row, currentConnectedArea.Col);
            connectedAreas.Add(currentConnectedArea);
            currentConnectedArea = null;

            TraverseAllAreas();
        }

        private static bool FindFirstTraversableCell(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == ' ')
                    {
                        currentConnectedArea = new ConnectedArea();

                        currentConnectedArea.Row = row;
                        currentConnectedArea.Col = col;

                        return true;
                    }
                }
            }

            return false;
        }

        private static void TraverseArea(int row, int col)
        {
            int totalRows = matrix.GetLength(0);
            int totalCols = matrix.GetLength(1);

            if (col < 0 || row < 0 || col >= totalCols || row >= totalRows)
            {
                return;
            }

            if (matrix[row, col] != ' ')
            {
                return;
            }

            matrix[row, col] = 'X';
            currentConnectedArea.Size++;

            TraverseArea(row, col - 1);
            TraverseArea(row - 1, col);
            TraverseArea(row, col + 1);
            TraverseArea(row + 1, col);
        }
    }
}
