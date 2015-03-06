using System;

//Problem 1. Numbers from 1 to N

//    Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space.

//Examples:
//n 	output
//3 	1 2 3
//5 	1 2 3 4 5

namespace _01PrintNNumbers
{
    class PrintNNums
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter positive integer n:");
            int n;
            while (!(int.TryParse(Console.ReadLine(), out n) && n > 0))
            {
                Console.WriteLine("Invalid input. Try again:");
            }
            for (int i = 1; i < (n + 1); i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
