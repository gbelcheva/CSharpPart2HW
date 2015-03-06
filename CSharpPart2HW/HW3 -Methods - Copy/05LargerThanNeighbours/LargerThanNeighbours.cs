using System;
using System.Linq;

//Problem 5. Larger than neighbours

//Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).

namespace _05LargerThanNeighbours
{
    class LargerThanNeighbours
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input array on a single line with spaces:");
            string[] input = Console.ReadLine().Split(' ');
            int[] numbers = input.Select(x => int.Parse(x)).ToArray();
            Console.WriteLine("Input index:");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine("Is the elemnt at index {0} larger than neighbours?\n{1}", index, IsLargerThanNeighbours(numbers, index));
        }
        static bool IsLargerThanNeighbours(int[] array, int index)
        {
            bool isLarger = false;
            if (array[index] > array[index - 1] && array[index] > array[index + 1])
            {
                isLarger = true;
                return isLarger;
            }
            return isLarger;
        }
    }
}
