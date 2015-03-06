using System;

//Problem 9. Matrix of Numbers

//    Write a program that reads from the console a positive integer number n (1 = n = 20) and prints a matrix like in the examples below. Use two nested loops.

//Examples:

//n = 2   matrix      n = 3   matrix      n = 4   matrix
//        1 2                 1 2 3               1 2 3 4
//        2 3                 2 3 4               2 3 4 5
//                            3 4 5               3 4 5 6
//                                                4 5 6 7


namespace _09MatrixNums
{
    class MatrixNums
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer n (1 <= n <= 20): ");
            int n;
            while (!(int.TryParse(Console.ReadLine(), out n) && n >= 1 && n <= 20))
            {
                Console.WriteLine("Invalid input. Try again:");
            }
            for (int i = 0; i <n; i++) //rows
            {
                for (int j = 1; j <= n; j++) //columns
                {
                    Console.Write("{0,3}", (j + i));
                }
                System.Console.WriteLine();
            }
        }
    }
}
