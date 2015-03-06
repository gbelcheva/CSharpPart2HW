using System;
using System.Linq;

//Problem 4. Appearance count

//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.

namespace _04AppearanceCount
{
    class AppearanceCount
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input array on a single line with spaces:");
            string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = input.Select(x => int.Parse(x)).ToArray();
            Console.WriteLine("Input number to search:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Number of times it appears:\n{0}", CountAppearance(numbers, number));
        }

        private static int CountAppearance(int[] array, int number)
        {
            int count = 0;
            foreach (var a in array)
            {
                if (number == a)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
