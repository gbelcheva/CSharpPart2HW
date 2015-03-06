using System;

//Problem 19.** Spiral Matrix

//    Write a program that reads from the console a positive integer number n (1 = n = 20) and prints a matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples below.

//Examples:

//n = 2   matrix      n = 3   matrix      n = 4   matrix
//        1 2                 1 2 3               1  2  3  4
//        4 3                 8 9 4               12 13 14 5
//                            7 6 5               11 16 15 6
//                                                10 9  8  7


namespace _19SpiralMatrix
{
    class SpiralMatrix
    {
        static void Main(string[] args)
        {
            Console.Write("Input n: ");
            int n;
            while (!(int.TryParse(Console.ReadLine(), out n) && n >= 1 && n <= 20))
            {
                Console.WriteLine("Invalid input. Try again:");
            }
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                matrix[0, i] = i + 1;
            }
            int row = 0;
            int column = n - 1;
            int counter = n;
            int sign = 1;
            for (int i = 0; i < n - 1; i++)
            {
                int rowFixed = (n - 1) - (row - ((1 - sign) / 2));
                int columnFixed = column;
                for (int j = 0; j < n - 1 - i; j++)
                {
                    counter++;
                    row = row + sign * 1;
                    matrix[row, columnFixed] = counter;
                    column = column - sign * 1;
                    matrix[rowFixed, column] = counter + n - 1 - i;
                }
                counter = counter + n - 1 - i;
                sign = sign * (-1);
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++) 
                {
                    Console.Write("{0, -4}", matrix[i, j]);
                }
                Console.WriteLine("\n");
            }
        }
    }
}
