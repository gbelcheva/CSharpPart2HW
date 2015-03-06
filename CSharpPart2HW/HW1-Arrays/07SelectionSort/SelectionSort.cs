using System;
using System.Linq;

//Problem 7. Selection sort

//    Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//    Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.


namespace _07SelectionSort
{
    class SelectionSort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input array to be sorted on a single line separated with spaces:");
InvalidInput:
            string[] array = Console.ReadLine().Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (!IsValidInput(array))
            {
                goto InvalidInput;
            }
            int[] nums = Array.ConvertAll(array, s => int.Parse(s));
            Console.WriteLine("Sorted:\n{0}", String.Join(" ", SelectSortArray(nums)));
        }

        static bool IsValidInput(string[] input)
        {
            bool isValid = true;
            int tempInt = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (!int.TryParse(input[i], out tempInt))
                {
                    Console.WriteLine("Invalid input. Try again.");
                    isValid = false;
                }
            }
            return isValid;
        }
        static int[] SelectSortArray(int[] array)
        {
            int smallest = array[0];
            int smallestIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (array[j] < smallest)
                    {
                        smallest = array[j];
                        smallestIndex = j;
                    }
                }
                array[smallestIndex] = array[i];
                array[i] = smallest;
                smallest = int.MaxValue;
            }
            return array;
        }
    }
}

//1 5 8 4 -2 0 7 20 19 5 3 50 9
