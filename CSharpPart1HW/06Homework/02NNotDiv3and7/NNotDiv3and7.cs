using System;

//Problem 2. Numbers Not Divisible by 3 and 7

//    Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n not divisible by 3 and 7, on a single line, separated by a space.

//Examples:
//n 	output
//3 	1 2
//10 	1 2 4 5 8 10

namespace _02NNotDiv3and7
{
    class NNotDiv3and7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter positive integer n:");
            int n;
            while (! (int.TryParse(Console.ReadLine(), out n) && n > 0))
            {
                Console.WriteLine("Invalid input. Try again:");
            }
            for (int i = 1; i < (n + 1); i++)
            {
                if (!(i % 3 == 0) && !(i % 7 == 0))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
