using System;

//Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N

//    Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
//    Use only one loop. Print the result with 5 digits after the decimal point.

//Examples:
//n 	x 	S
//3 	2 	2.75000
//4 	3 	2.07407
//5 	-4 	0.75781

namespace _05Sum
{
    class Sum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integers n and x:");
            int n;
            int x;
            while (!(int.TryParse(Console.ReadLine(), out n) && int.TryParse(Console.ReadLine(), out x)))
            {
                Console.WriteLine("Invalid input. Try again:");
            }
            double sum = 0;
            int factorial = 1;
            for (int i = 0; i <= n; i++)
            {
                sum = sum + (factorial / Math.Pow(x, i));
                factorial *= (i + 1);
            }
            Console.WriteLine("Sum = {0:0.00000}", sum);
        }
    }
}
