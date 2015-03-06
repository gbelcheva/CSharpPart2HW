using System;
using System.Linq;
using System.Globalization;
using System.Threading;

//Problem 7. Sum of 5 Numbers

//    Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

//Examples:
//numbers 	sum
//1 2 3 4 5 	15
//10 10 10 10 10 	50
//1.5 3.14 8.2 -1 0 	11.84

namespace _07Sum5Numbers
{
    class Sum5Numbers
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            Console.WriteLine("Input five numbers separated with space:");
            var allNumbers = Console.ReadLine().Split(' ').Take(5);
            Double[] numbers = allNumbers.Select(d => Convert.ToDouble(d)).ToArray();
            double sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum = sum + numbers[i];
            }
            Console.WriteLine("Sum: {0}", sum);
        }
    }
}
