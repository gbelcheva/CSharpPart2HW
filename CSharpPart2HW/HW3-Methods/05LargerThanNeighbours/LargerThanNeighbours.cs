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
            string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = input.Select(x => int.Parse(x)).ToArray();
            Console.WriteLine("Input index:");
            int index = int.Parse(Console.ReadLine());
            if (0 > index || index > numbers.Length - 1)
            {
                Console.WriteLine("Such element does not exist.");
                return;
            }
            Console.WriteLine("Is the element {0} at index {1} larger than neighbours?\n{2}", numbers[index], index, IsLargerThanNeighbours(numbers, index));
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
