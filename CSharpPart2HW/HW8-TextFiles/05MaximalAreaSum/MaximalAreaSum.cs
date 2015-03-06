using System;
using System.Linq;
using System.IO;

//Problem 5. Maximal area sum

//    Write a program that reads a text file containing a square matrix of numbers.
//    Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
//        The first line in the input file contains the size of matrix N.
//        Each of the next N lines contain N numbers separated by space.
//        The output should be a single number in a separate text file.

//Example:
//input 	output
//4
//2 3 3 4
//0 2 3 4
//3 7 1 2
//4 3 3 2 	17

namespace _05MaximalAreaSum
{
    class MaximalAreaSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input matrix file:");
            string inputFile = Console.ReadLine();
            string[] file = File.ReadAllLines(inputFile);
            int size = 2;
            int rows = int.Parse(file[0]);
            int[][] matrix = new int[rows][];
            for (int i = 0; i < file.Length - 1; i++)
            {
                string[] tmp = file[i + 1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                matrix[i] = tmp.Select(x => int.Parse(x)).ToArray();
            }
            int tmpSum = 0;
            int maxSum = 0;
            for (int i = 0; i < matrix[0].Length - (size - 1); i++)
            {
                for (int j = 0; j < matrix.Length - (size - 1); j++)
                {
                    for (int k = i; k < i + size; k++)
                    {
                        for (int l = j; l < j + size; l++)
                        {
                            tmpSum += matrix[k][l];
                        }
                    }
                    if (tmpSum > maxSum)
                    {
                        maxSum = tmpSum;
                    }
                    tmpSum = 0;
                }
            }
            Console.WriteLine("Input output file:");
            string outputFile = Console.ReadLine();
            File.WriteAllText(outputFile, maxSum.ToString());
        }
    }
}
