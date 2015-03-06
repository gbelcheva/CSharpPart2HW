using System;
using System.Linq;

//Problem 6. First larger than neighbours

//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
//Use the method from the previous exercise.

namespace _06FirstLargerThanNeighbours
{
    class FirstLargerThanNeighbours
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input array on a single line with spaces:");
            string[] input = Console.ReadLine().Split(' ');
            int[] numbers = input.Select(x => int.Parse(x)).ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (IsLargerThanNeighbours(numbers,numbers[i]))
                {
                    Console.WriteLine("First larger than neighbours is:\n", numbers[i]);
                    break;
                }
            }
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
