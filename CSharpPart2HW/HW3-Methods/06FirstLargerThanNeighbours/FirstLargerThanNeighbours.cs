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
            string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = input.Select(x => int.Parse(x)).ToArray();
            Console.WriteLine("First larger than neighbours is at index:\n{0}", IsFirstLargerThanNeighbours(numbers));
               
        }

        static int IsFirstLargerThanNeighbours(int[] array) 
        {
            int noLarger = -1;
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (IsLargerThanNeighbours(array, i))
                {
                    return i;
                }
            }
            return noLarger;
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
