using System;
using System.Linq;

//Problem 6. Sum integers

//    You are given a sequence of positive integer values written into a string, separated by spaces.
//    Write a function that reads these values from given string and calculates their sum.

//Example:
//input 	output
//"43 68 9 23 318" 	461

namespace _06SumIntegers
{
    class SumIntegers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input string of integers:");
            Console.WriteLine("The sum is: {0}", CalcSum(Console.ReadLine()));
        }

        private static int CalcSum(string inputString)
        {
            string[] input = inputString.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = input.Select(x => int.Parse(x)).ToArray();
            return numbers.Sum();
        }
    }
}
