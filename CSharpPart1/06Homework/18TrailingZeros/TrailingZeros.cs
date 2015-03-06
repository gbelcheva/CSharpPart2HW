using System;

//Problem 18.* Trailing Zeroes in N!

//    Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
//    Your program should work well for very big numbers, e.g. n=100000.

//Examples:
//n 	trailing zeroes of n! 	explaination
//10 	2 	3628800
//20 	4 	2432902008176640000
//100000 	24999 	think why

namespace _18TrailingZeros
{
    class TrailingZeros
    {
        static void Main(string[] args)
        {
            Console.Write("Input number:\n");
            int n;
            while (!(int.TryParse(Console.ReadLine(), out n)))
            {
                Console.WriteLine("Invalid number\n");
            }
            int t = 5;
            int trail = 0;
            int quotient = n;
            while (quotient >= 1)
            {
                trail = trail + n / t;
                t = t * 5;
                quotient = n / t;
            }
            Console.WriteLine(trail);
        }
    }
}
