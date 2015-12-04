﻿namespace _08.PathInMatrixCheck
{
    using System;
    using System.Collections.Generic;

    public class Matrix
    {
        private const char Unpassable = '0';
        private bool pathFound = false;

        private char[,] matrix;
        private int[,] dir = new int[,] { { 1, 0 }, { 0, 1 }, { -1, 0 }, { 0, -1 } };
        private List<char> directions = new List<char>();
        private char[] charDir = new[] { 'D', 'R', 'U', 'L' };

        public Matrix(char[,] matrix)
        {
            this.matrix = matrix;
        }

        public void FindPaths(int row, int col, char direction)
        {
            if (pathFound)
            {
                return;
            }

            if (!InRange(row, col))
            {
                return;
            }

            if (matrix[row, col] == '*' ||
                matrix[row, col] == Unpassable)
            {
                return;
            }

            if (matrix[row, col] == 'e')
            {
                directions.Add(direction);
                PrintPath();
                pathFound = true;
                directions.RemoveAt(this.directions.Count - 1);
                return;
            }

            directions.Add(direction);
            MarkCurrent(row, col);
            for (int i = 0; i < dir.GetLength(0); i++)
            {
                FindPaths(row + dir[i, 0], col + dir[i, 1], charDir[i]);
            }
            directions.RemoveAt(this.directions.Count - 1);
        }

        private void UnmarkCurrent(int row, int col)
        {
            this.matrix[row, col] = ' ';
        }

        private void MarkCurrent(int row, int col)
        {
            this.matrix[row, col] = Unpassable;
        }

        private void PrintPath()
        {
            Console.WriteLine(string.Join("", directions));
        }

        private bool InRange(int row, int col)
        {
            bool rowInRange = row >= 0 && row < matrix.GetLength(0);
            bool colInRange = col >= 0 && col < matrix.GetLength(1);
            return rowInRange && colInRange;
        }
    }
}
