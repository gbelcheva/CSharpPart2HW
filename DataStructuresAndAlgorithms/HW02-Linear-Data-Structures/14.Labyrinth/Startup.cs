////(*) We are given a labyrinth of size N x N.

////    Some of its cells are empty (0) and some are full(x).
////    We can move from an empty cell to another empty cell if they share common wall.
////    Given a starting position (*) calculate and fill in the array the minimal distance from this position to any other cell in the array. Use "u" for all unreachable cells.

//namespace Labyrinth
//{
//    using System;
//    using System.Collections.Generic;

//    public class Startup
//    {
//        private static string[,] matrix;
//        private static int totalRows;
//        private static int totalCols;
//        private static List<char> directions = new List<char>();
//        private static int totalPaths = 0;

//        public static void Main(string[] args)
//        {

//            matrix = new string[,] {
//                                {"0", "0", "0", "x", "0", "x"},
//                                {"0", "x", "0", "x", "0", "x"},
//                                {"0", "*", "x", "0", "x", "0"},
//                                {"0", "x", "0", "0", "0", "0"},
//                                {"0", "0", "0", "x", "x", "0"},
//                                {"0", "0", "0", "x", "0", "x"}
//                             };

//            PrintArray(matrix);
//            FindAllPaths(matrix);
//            PrintArray(matrix);

//        }

//        private static void PrintArray(string[,] matrix)
//        {
//            totalRows = matrix.GetLength(0);
//            totalCols = matrix.GetLength(1);
//            string bottomLine = new String('-', 2 * totalCols);

//            Console.WriteLine(bottomLine);

//            for (int i = 0; i < totalRows; i++)
//            {
//                for (int j = 0; j < totalCols; j++)
//                {
//                    Console.Write(string.Format("|{0}", matrix[i, j]));
//                }

//                Console.WriteLine("|" + Environment.NewLine + bottomLine);
//            }
//        }

//        private static void FindAllPaths(string[,] matrix)
//        {
//            totalRows = matrix.GetLength(0);
//            totalCols = matrix.GetLength(1);

//            for (int r = 0; r < matrix.GetLength(1); r++)
//            {
//                for (int c = 0; c < matrix.GetLength(0); c++)
//                {
//                    if (matrix[r, c] == "0")
//                    {
//                        FindPath(2, 1, ' ', r, c, 0);
//                    }
//                }
//            }

//            Console.WriteLine("Total paths found: {0}", totalPaths);
//        }

//        private static void FindPath(int currentRow, int currentCol, char dir, int endRow, int endCol, int counter)
//        {
//            if (currentCol < 0 || currentRow < 0 || currentCol >= totalCols || currentRow >= totalRows)
//            {
//                return;
//            }

//            if (matrix[currentRow, currentCol] == "0")
//            {
//                directions.RemoveAt(0);
//                directions.Add(dir);
//                Console.WriteLine(string.Join("", directions));
//                totalPaths++;
//            }

//            if (matrix[currentRow, currentCol] == "x")
//            {
//                return;
//            }

//            if (matrix[currentRow, currentCol] == "0")
//            {
//                directions.Add(dir);
//                counter++;
//                matrix[currentRow, currentCol] = counter.ToString();

//                return;
//            }

//            directions.Add(dir);
//            counter++;
//            if (matrix[currentRow, currentCol] != "x" && 
//                matrix[currentRow, currentCol] != "*" &&
//                Int32.Parse(matrix[currentRow, currentCol]) > counter)
//            {
//                matrix[currentRow, currentCol] = counter.ToString();
//            }

//            FindPath(currentRow, currentCol - 1, 'L', endRow, endCol, counter);
//            FindPath(currentRow - 1, currentCol, 'U', endRow, endCol, counter);
//            FindPath(currentRow, currentCol + 1, 'R', endRow, endCol, counter);
//            FindPath(currentRow + 1, currentCol, 'D', endRow, endCol, counter);

//            //matrix[currentRow, currentCol] = "0";
//            directions.RemoveAt(directions.Count - 1);
//        }
//    }
//}
